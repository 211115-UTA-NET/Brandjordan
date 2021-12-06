#Write a bash script that prints the string "HELLO"
#echo "HELLO"

#Write a Bash script which accepts  as input and displays the greeting "Welcome (name)"
#read name
#echo "Welcome $name"

#Use a for loop to display the natural numbers from 1 to 50.
#for nat in {1..50..1}
#do
#echo $nat
#done

#Your task is to use for loops to display only odd natural numbers from 1 to 99.
#for bj in {1..99..2}
#do
#echo $bj
#done

#Read in one character from STDIN. If the character is 'Y' or 'y' display "YES". 
#If the character is 'N' or 'n' display "NO". No other character will be provided as input.
#read yn
#if [ $yn == "Y" ] || [ $yn == 'y' ]
#then
#echo 'YES';
#else
#echo 'NO';
#fi

#Given two integers, X and Y, identify whether X < Y or X > Y or X = Y.
#Exactly one of the following lines:
#- X is less than Y
#- X is greater than Y
#- X is equal to Y
#read x
#read y 
#if [ $x -lt $y ]
#then
#echo "X is less than Y"
#elif [ $x -gt $y ]
#then
#echo "X is greater than Y"
#else
#echo "X is equal to Y"
#fi

#Given three integers (X, Y, and Z) representing the three sides of a triangle, 
#identify whether the triangle is scalene, isosceles, or equilateral. If all three
#sides are equal, output EQUILATERAL. Otherwise, if any two sides are equal, output ISOSCELES.
#Otherwise, output SCALENE.
#read x
#read y
#read z
#if [[ $x -eq $y && $x -eq $z ]]
#then
#   echo "EQUILATERAL"
#elif [[ $x -eq $y || $x -eq $z || $y -eq $z ]]
#then
#   echo "ISOSCELES"
#elif  [[ $x -ne $y && $x -ne $z && $y -ne $z ]];
#then
#    echo "SCALENE"
#fi

#Compute the Average

