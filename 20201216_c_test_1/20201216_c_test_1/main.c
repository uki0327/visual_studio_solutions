#include <stdio.h>
int main() {
  int input;
  char isMultipleOfFive;
  char isMultipleOfSeven;

  while(1) {
    printf("\n*** Let me check if it's a multiple of 5 or 7. ***\n");
    printf("*** Please input a number that is larger than 0 : "); 
    scanf("%d", &input);
    isMultipleOfFive = 0;
    isMultipleOfSeven = 0;

    if((input % 5 == 0) && (input > 0)) {
      printf("\n%d is the multiple number of 5",input);
      isMultipleOfFive = 1;
    }

    if((input % 7 == 0) && (input > 0)) {
      if(isMultipleOfFive){ 
      printf(" and 7.");
      } else printf("\n%d is the multiple number of 7.", input);
      isMultipleOfSeven = 1;
    }

    if((isMultipleOfFive == 0) && (isMultipleOfSeven == 0))
      printf("\nIt's not a multiple number of 5 or 7 !!!");

    if(input == 0) return 0;
 
   printf("\n");
  }

  return 0;
}