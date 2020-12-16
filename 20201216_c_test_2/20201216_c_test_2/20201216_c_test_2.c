#include <stdio.h>
int main() {
  char input;
  while(1) {
    printf("\n*** Let me shift between UPPER and LOWERCASE. ***\n");
    printf("*** Please input a alphabet letter only : "); 
    scanf("%c", &input);

    if((input > 0x40) && (input < 0x5B)) {
      printf("\nIt's an Upper-case. The lower case is gonna be: %c\n", (input + 0x20));

    } else if((input > 0x60) && (input < 0x7B)) {
      printf("\nIt's a Lower-case. the Upper case is gonna be: %c\n", (input - 0x20));

    } else if(input == 0x30) {
      return 0;
    } else {
       printf("\nWHAT ARE YOU TOLKING ABOUT??? TYPE AGAIN!!!\n");
    }
    if(input == 0) return 0;
	getchar();
    printf("\n");
  } // while LOOP 문 종료

  return 0;
}