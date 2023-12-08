Imports System
Imports System.Reflection
Imports System.Reflection.Metadata.Ecma335

Module Program
    Sub Main()
        'declare variables
        Dim Str1 As String
        Dim n_pos, b_pos As Integer

        'initialize
        Str1 = ""
        n_pos = 0
        b_pos = 0

        'prompt to input string
        Console.WriteLine("enter a string: ")
        Str1 = Console.ReadLine()

        'find postition of strings "not" and "bad" in the entered string
        n_pos = InStr(Str1, "not")
        b_pos = InStr(Str1, "bad")
        'condition to check if pos of "not" and "bad" is not equal to -1, and "bad" comes after "not"  
        If n_pos <> -1 And b_pos <> -1 And b_pos > n_pos Then
            Dim resultString As String = Left(Str1, n_pos - 1) & "good"
            Console.WriteLine(resultString)
            'if above conditions are false, then output the string as it is.
        Else

            Console.WriteLine(Str1)






        End If


    End Sub
End Module






