Imports System
Imports System.IO
Imports System.Runtime.ConstrainedExecution

Module Program
    Sub Main()
        ' replacing character from string with another character.
        'declaration of variables
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        'initialization
        Str1 = ""
        Str2 = ""

        'input variables
        Console.Write("enter the string: ")
        Str1 = Console.ReadLine()
        Console.Write("enter character to replace: ")
        Char1 = Console.ReadLine()
        Console.Write("enter character to replace with: ")
        Char2 = Console.ReadLine()

        'loop starts 
        For i = 1 To Len(Str1)
            Char3 = Mid(Str1, i, 1)
        'condition to compare characters
            If Char1 <> Char3 Then
                Str2 = Str2 + Char3
            Else Str2 = Str2 + Char2
            End If
        Next

        'output final string with prompt
        Console.WriteLine("final string is: " + Str2)
        Console.ReadLine()










    End Sub
End Module
