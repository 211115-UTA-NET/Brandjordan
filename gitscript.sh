#!/usr/bin/bash

#Prompt the user
Echo "Enter the file name you would like to add. Include file extension"

#Accept user input
Read name

#Filter only .txt, .md, .sh, .png files
ext="${name##*.}"

If (( $ext == “txt” || $ext == “md” || $ext == “sh” || $ext == “png”))
     Then

#Add the entered file to staging
Git add $name

#Prompt user for commit message
Echo "Please enter the commit message"

#Accept user input
Read message

#Commit the staged files
Git commit -m "$message"

#Push the commit
git push

else
	echo "That file will not be accepted"

fi