[3;38;2;102;217;239mnamespace[0m[38;2;248;248;242m [0m[38;2;166;226;46mStackImplementation[0m
[38;2;248;248;242m{[0m
[38;2;248;248;242m    [0m[38;2;249;38;114minternal[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mclass[0m[38;2;248;248;242m [0m[4;38;2;102;217;239mStack[0m[38;2;248;248;242m<[0m[3;38;2;166;226;46mT[0m[38;2;248;248;242m>[0m
[38;2;248;248;242m    [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m        [0m[38;2;249;38;114mprivate[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mint[0m[38;2;248;248;242m [0m[38;2;255;255;255m_top[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;249;38;114mprivate[0m[38;2;248;248;242m [0m[38;2;249;38;114mconst[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mint[0m[38;2;248;248;242m [0m[38;2;255;255;255mCapacity[0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;190;132;255m4[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;249;38;114mprivate[0m[38;2;248;248;242m [0m[38;2;249;38;114mreadonly[0m[38;2;248;248;242m [0m[3;38;2;166;226;46mT[0m[38;2;248;248;242m[[0m[38;2;248;248;242m][0m[38;2;248;248;242m [0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;249;38;114mnew[0m[38;2;248;248;242m [0m[3;38;2;166;226;46mT[0m[38;2;248;248;242m[[0m[38;2;255;255;255mCapacity[0m[38;2;248;248;242m][0m[38;2;248;248;242m;[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mpublic[0m[38;2;248;248;242m [0m[38;2;166;226;46mStack[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;255;255;255m_top[0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;249;38;114m-[0m[38;2;190;132;255m1[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mprivate[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mbool[0m[38;2;248;248;242m [0m[38;2;166;226;46mIsEmpty[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;249;38;114mreturn[0m[38;2;248;248;242m [0m[38;2;255;255;255m_top[0m[38;2;248;248;242m [0m[38;2;249;38;114m<[0m[38;2;248;248;242m [0m[38;2;190;132;255m0[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m
[38;2;248;248;242m        [0m[38;2;249;38;114mprivate[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mbool[0m[38;2;248;248;242m [0m[38;2;166;226;46mIsFull[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;249;38;114mreturn[0m[38;2;248;248;242m [0m[38;2;255;255;255m_top[0m[38;2;248;248;242m [0m[38;2;249;38;114m==[0m[38;2;248;248;242m [0m[38;2;255;255;255mCapacity[0m[38;2;248;248;242m [0m[38;2;249;38;114m-[0m[38;2;248;248;242m [0m[38;2;190;132;255m1[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mpublic[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mvoid[0m[38;2;248;248;242m [0m[38;2;166;226;46mPeek[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;255;255;255mSystem[0m[38;2;248;248;242m.[0m[38;2;255;255;255mConsole[0m[38;2;248;248;242m.[0m[38;2;248;248;242mWriteLine[0m[38;2;248;248;242m([0m[38;2;249;38;114m![0m[38;2;248;248;242mIsEmpty[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m [0m[38;2;249;38;114m?[0m[38;2;248;248;242m [0m[38;2;230;219;116m$"[0m[38;2;230;219;116mThe topmost element is: [0m[38;2;248;248;242m{[0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m[[0m[38;2;255;255;255m_top[0m[38;2;248;248;242m][0m[38;2;248;248;242m}[0m[38;2;230;219;116m"[0m[38;2;248;248;242m [0m[38;2;249;38;114m:[0m[38;2;248;248;242m [0m[38;2;230;219;116m"[0m[38;2;230;219;116mThe stack is empty.[0m[38;2;230;219;116m"[0m[38;2;248;248;242m)[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mpublic[0m[38;2;248;248;242m [0m[3;38;2;166;226;46mT[0m[38;2;248;248;242m [0m[38;2;166;226;46mPop[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;249;38;114mreturn[0m[38;2;248;248;242m [0m[38;2;249;38;114m![0m[38;2;248;248;242mIsEmpty[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m [0m[38;2;249;38;114m?[0m[38;2;248;248;242m [0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m[[0m[38;2;255;255;255m_top[0m[38;2;249;38;114m-[0m[38;2;249;38;114m-[0m[38;2;248;248;242m][0m[38;2;248;248;242m [0m[38;2;249;38;114m:[0m[38;2;248;248;242m [0m[38;2;249;38;114mdefault[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mpublic[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mvoid[0m[38;2;248;248;242m [0m[38;2;166;226;46mPush[0m[38;2;248;248;242m([0m[3;38;2;166;226;46mT[0m[38;2;248;248;242m [0m[3;38;2;253;151;31melement[0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;249;38;114mif[0m[38;2;248;248;242m [0m[38;2;248;248;242m([0m[38;2;249;38;114m![0m[38;2;248;248;242mIsFull[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m)[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m                [0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m[[0m[38;2;249;38;114m+[0m[38;2;249;38;114m+[0m[38;2;255;255;255m_top[0m[38;2;248;248;242m][0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;255;255;255melement[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m}[0m
[38;2;248;248;242m            [0m[38;2;249;38;114melse[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m                [0m[38;2;255;255;255mSystem[0m[38;2;248;248;242m.[0m[38;2;255;255;255mConsole[0m[38;2;248;248;242m.[0m[38;2;248;248;242mWriteLine[0m[38;2;248;248;242m([0m[38;2;230;219;116m"[0m[38;2;230;219;116mCannot push - the stack is full.[0m[38;2;230;219;116m"[0m[38;2;248;248;242m)[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m}[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m        [0m[38;2;249;38;114mpublic[0m[38;2;248;248;242m [0m[38;2;249;38;114moverride[0m[38;2;248;248;242m [0m[3;38;2;102;217;239mstring[0m[38;2;248;248;242m [0m[38;2;166;226;46mToString[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m            [0m[38;2;249;38;114mif[0m[38;2;248;248;242m [0m[38;2;248;248;242m([0m[38;2;248;248;242mIsEmpty[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m)[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m                [0m[38;2;249;38;114mreturn[0m[38;2;248;248;242m [0m[38;2;230;219;116m"[0m[38;2;230;219;116mThe stack is empty.[0m[38;2;230;219;116m"[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m            [0m[3;38;2;102;217;239mvar[0m[38;2;248;248;242m [0m[38;2;255;255;255mdepiction[0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;230;219;116m"[0m[38;2;230;219;116m"[0m[38;2;248;248;242m;[0m

[38;2;248;248;242m            [0m[38;2;249;38;114mfor[0m[38;2;248;248;242m [0m[38;2;248;248;242m([0m[3;38;2;102;217;239mvar[0m[38;2;248;248;242m [0m[38;2;255;255;255mindex[0m[38;2;248;248;242m [0m[38;2;249;38;114m=[0m[38;2;248;248;242m [0m[38;2;190;132;255m0[0m[38;2;248;248;242m;[0m[38;2;248;248;242m [0m[38;2;255;255;255mindex[0m[38;2;248;248;242m [0m[38;2;249;38;114m<[0m[38;2;248;248;242m [0m[38;2;255;255;255m_top[0m[38;2;248;248;242m;[0m[38;2;248;248;242m [0m[38;2;255;255;255mindex[0m[38;2;249;38;114m+[0m[38;2;249;38;114m+[0m[38;2;248;248;242m)[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m{[0m
[38;2;248;248;242m                [0m[38;2;255;255;255mdepiction[0m[38;2;248;248;242m [0m[38;2;249;38;114m+=[0m[38;2;248;248;242m [0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m[[0m[38;2;255;255;255mindex[0m[38;2;248;248;242m][0m[38;2;248;248;242m.[0m[38;2;248;248;242mToString[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m [0m[38;2;249;38;114m+[0m[38;2;248;248;242m [0m[38;2;190;132;255m' '[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m            [0m[38;2;248;248;242m}[0m

[38;2;248;248;242m            [0m[38;2;255;255;255mdepiction[0m[38;2;248;248;242m [0m[38;2;249;38;114m+=[0m[38;2;248;248;242m [0m[38;2;255;255;255m_stack[0m[38;2;248;248;242m[[0m[38;2;255;255;255m_top[0m[38;2;248;248;242m][0m[38;2;248;248;242m.[0m[38;2;248;248;242mToString[0m[38;2;248;248;242m([0m[38;2;248;248;242m)[0m[38;2;248;248;242m;[0m

[38;2;248;248;242m            [0m[38;2;249;38;114mreturn[0m[38;2;248;248;242m [0m[38;2;230;219;116m$"[0m[38;2;230;219;116mStack: [[0m[38;2;248;248;242m{[0m[38;2;255;255;255mdepiction[0m[38;2;248;248;242m}[0m[38;2;230;219;116m][0m[38;2;230;219;116m"[0m[38;2;248;248;242m;[0m
[38;2;248;248;242m        [0m[38;2;248;248;242m}[0m
[38;2;248;248;242m    [0m[38;2;248;248;242m}[0m
[38;2;248;248;242m}[0m