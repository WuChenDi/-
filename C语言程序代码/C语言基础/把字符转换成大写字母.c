#include <string.h>
#include <stdio.h>
//#include <ctype.h>
 
int main(void)
{
   int length, i;
   char *string = "this is a string";
 
   length = strlen(string);
   for (i=0; i<length; i++)
   {
      string[i] = toupper(string[i]);
   }
 
   printf("%s\n",string);
 
   return 0;
}

