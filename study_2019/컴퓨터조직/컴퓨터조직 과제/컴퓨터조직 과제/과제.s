# 1부터 100까지 홀수의 합을 출력하는 프로그램

#프로그램에서 사용할 데이터 영역
   .data
msg: .asciiz "Sum of odd numbers : "   # 출력할 메세지
number: .word 100   #연산에 사용할 수

#프로그램의 코드 영역
   .text
   .globl   main
main:

   lw $s0, number   # s0 레지스터에 100을 가지고 온다.
   li $t0, 2 #나눠주는 수
   li $t3, 1 #slt로 100이 넘어가는지 비교해주는 수
   
   # 출력 : Sum of odd numbers : 2500

loop:

   addi $s1,$s1,1 # s1값을 1부터 100까지 1씩 올려준다.
   div $s1,$t0 #나누기
   mfhi $s2 # hi에 있는 나머지 값 대입
   
   beq $s2,$t1,loop # 짝수이면 loop으로 돌아간다
   slt $t1,$s0,$s1 # s1값이 100을 넘는지 조사
   beq $t1,$t3,print # slt 값을 받아서 100이 넘으면 print로 조건분기
   
   add $t2,$t2,$s1 # 값이 홀수이면 t2에 더해준다.

   j loop # 반복문

   

print:#결과를 출력하는 부분 ▽▽▽▽▽▽▽▽
   
   #msg로 레이블된 메세지를 출력
   li $v0, 4   # $v0에 4를 저장 / print -string 으로 변환
   la $a0, msg # 문자열의 주소를 $a0에 로드
   syscall      # $v0에 있는 내용에 따라 시스템이 작동 (여기서는 4이므로 msg 출력)

   #값을 출력하는 부분
   #최종 결과는 $t2 레지스터에 저장되어 있다고 가정하고(t2에 값을 계속해서 저장해야된다.)
   #t2 레지스터 값을 출력한다
   li $v0, 1 # $v0가 1이면 print-int
   addi $a0, $t2, 0
   syscall # $a0 출력 (1부터 100까지 홀수의 합)

   #프로그램 종료
   li $v0, 10   #exit ($v0 가 10이면 프로그램 종료)
   syscall