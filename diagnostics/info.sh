#!/usr/bin/env bash
_modules=('system' 'bat' 'bat_config' 'bat_wrapper' 'tool')
_modules_consented=()


# -----------------------------------------------------------------------------
# Modules:
# -----------------------------------------------------------------------------

_bat_:description() {
	_collects "Version information for 'bat'."
}

_bat_config_:description() {
	_collects "The environment variables used by 'bat'."
	_collects "The 'bat' configuration file."
}

_bat_wrapper_:description() {
	_collects "Any wrapper script used by 'bat'."
}

_system_:description() {
	_collects "Operating system name."
	_collects "Operating system version."
}

_tool_:description() {
	_collects "Version information for 'less'."
}


# - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

_bat_:run() {
	_out bat --version
	_out env | grep '^BAT_\|^PAGER='
}

_bat_config_:run() {
	if [[ -f "$(bat --config-file)" ]]; then 
		_out cat "$(bat --config-file)"; 
	fi
}

_bat_wrapper_:run() {
	if file "$(which bat)" | grep "text executable" &>/dev/null; then
		_out cat "$(which bat)"
	fi
}

_system_:run() {
	_out uname -srm

	if command -v "sw_vers" &>/dev/null; then _out sw_vers; fi
	if command -v "lsb_release" &>/dev/null; then _out lsb_release -a; fi
}

_tool_:run() {
	_out less --version | head -n1
}


# -----------------------------------------------------------------------------
# Functions:
# -----------------------------------------------------------------------------

_out() {
	printf "\n+" 1>&2
	printf " %s" "$@" 1>&2
	printf "\n" 1>&2

	"$@" 2>&1
}

_tput() {
	tput "$@" 1>&2 2>/dev/null
}

_collects() {
	printf " - %s\n" "$1" 1>&2
}

_ask_module() {
	_tput clear
	_tput cup 0 0

cat 1>&2 <<EOF
--------------------------------------------------------------------------------
This script will collect information to help assist in issue resolution.
You will be provided with a description of the data collected, and will be
offered the opportunity to give consent for each piece of information collected.
--------------------------------------------------------------------------------
EOF

	# Print description.
	_tput setaf 3
	printf "The following data will be collected:\n" 1>&2
	_tput sgr0
	"_$1_:description"
	_tput sgr0
	
	# Print preview.
	_tput setaf 3
	printf "\nThe following commands will be run:\n" 1>&2
	_tput sgr0
	declare -f "_$1_:run" \
		| sed 's/^ *//; s/;$//' \
		| grep '^_out ' \
		| sed 's/^_out //' 1>&2

	# Prompt
	printf "\n" 1>&2
	local response
	while true; do
		_tput cup "$(( $(tput lines 2>/dev/null || echo 22) - 1 ))"
		_tput el
		read -er -p "Collect $(sed 's/_/ /' <<< "$1") data? [Y/n] " response
		case "$response" in
			Y|y|yes|'') return 0 ;;
			N|n|no)     return 1 ;;
			*) continue
		esac
	done
}

_run_module() {
	printf "========== %s ==========\n" "$1"
	"_$1_:run"
}


# -----------------------------------------------------------------------------
# Functions:
# -----------------------------------------------------------------------------

# Ask for consent.
if [[ "$1" = '-y' ]]; then
	_modules_consented=("${_modules[@]}")
else
	trap '_tput rmcup; exit 1' INT
	_tput smcup
	for _module in "${_modules[@]}"; do
		if _ask_module "$_module"; then
			_modules_consented+=("$_module")
		fi
	done
	_tput rmcup
fi

# Collect information.
for _module in "${_modules_consented[@]}"; do
	_run_module "$_module"
	printf "\n"
done

