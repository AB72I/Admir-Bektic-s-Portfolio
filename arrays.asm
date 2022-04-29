.data
	myarray: .space 40
	prompt: .asciiz "Enter 10 numbers: "
	newline: .asciiz "\n"
.text 
	li $v0, 4   # load integer
	la $a0, prompt  #load address
	syscall 
	
	
	addi $t0, $zero, 0
	
loop:	
	beq $t0,40, exit
	#get user numbers
	li $v0, 5  # service is set to be read int
	syscall    # service is performed and v0  will have the user input	
	sw $v0, myarray($t0)   #v0 is stored in the array
	addi $t0, $t0, 4
	j loop
exit:
	addi $t0, $zero, 36
	
	#print a new line
	li $v0, 4
	la $a0, newline
	syscall 
	
loop2:
	beq $t0, -4, exit2 #loop ends at 0
	
	lw $t6, myarray($t0)
	
	subi $t0, $t0, 4
	
	#print current number
	li $v0, 1
	addi $a0, $t6, 0
	syscall
	
	#print a new line
	li $v0, 4
	la $a0, newline
	syscall 
	
	j loop2

exit2:
	li $v1, 10
	syscall 