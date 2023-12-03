Imports System

Module Program
    Sub Main()
        'declare all strings
        Dim Str1, Str2, Str3, Str4 As String
        'initialization
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Str4 = ""

        'output prompt to input string
        Console.Write("enter a string: ")
        Str1 = Console.ReadLine()

        'condition to check if lenght of string is more or less than 2
        If Len(Str1) > 2 Then
            Str2 = Left(Str1, 2) 'extract functions.
            Str3 = Right(Str1, 2)
            Str4 = Str2 & Str3 'concatenation of strings.
            Console.WriteLine("final string is: " & Str4)

        Else Console.WriteLine("the final string is: " & Str1) 'returns same string if length is less then or equal to 2
        End If


        Console.ReadLine()







    End Sub
End Module
