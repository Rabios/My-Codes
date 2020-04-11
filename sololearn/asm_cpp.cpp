#include <iostream>
#include <stdio.h>
using namespace std;

/*
Credits & Special Thanks To:
1 - Rabia Alhaffar[Me](Main Project Creator)
2 - Aleksandar Nedeljkovic(Correcting/Editing)
3 - Daljeet @ Bengaluru/Daljeet Singh(Correcting/Editing)
*/

//Created By Rabia Alhaffar In 22/2/2019
//An Assembly Into C++ Example!!!
//Using The Command __asm__ And String Marks You Can Make Assembly Into C++!!!
//Beautiful Information:Most Of Windows Operating Systems Have Assembly Attached Into C++ For Performance!!!
//Check Out Comments In Both Codes!!!



/* Aleksandar Nedeljkovic's Code

int main() {
    int arg1, arg2, add;
    __asm__( "addl %%ebx, %%eax;"
        : "=a" (add)
        : "a" (arg1), "b" (arg2) ); 
        cout << add;
    return 0 ;
}
*/

/*  Daljeet @ Bengaluru's(Daljeet Singh) Code Under*/
/* Thanks To Both Aleksandar And Daljeet For Helping Me In This Project */

int main() {
    int n1 = 10,n2 = 20,sum = 0;
    __asm__
    (
    "movl %1, %%eax   \n"//10 in eax
    "movl %2, %%ebx   \n"//20 in ebx
    "addl %%ebx,%%eax \n"//add 20+10
 //you can check by commenting out (nop) line 17 and change eax to ebx line 19
    "movl %%eax, %0   \n"//now eax 30
    : "=r" (sum)         //output
    : "r" (n1), "r" (n2) //inputs
    );
    cout << sum << endl;
    return 0;
}

//https://www.ibiblio.org/gferg/ldp/GCC-Inline-Assembly-HOWTO.html#s4