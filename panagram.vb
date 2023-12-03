Imports System

Module Program
    Sub Main()
      
        'declaration of variables
        Dim Str1, Alpha As String
        Dim Char1 As Char
        Dim i As Integer
        Dim IsPanagram As Boolean
    
        ' initialization
        Str1 = ""
        Alpha = ""

        ' output prompt for inputting string
        Console.Write("Enter the string: ")
        Str1 = UCase(Console.ReadLine)
        ' variable introduced containing characters from which characters of string would be located
        Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        ' flag introduced which is TRUE when string is panagram and FALSE when it is not.
        IsPanagram = True
        ' loop starts
        For i = 1 To Len(Alpha)
            Char1 = Mid(Alpha, i, 1)
        ' function to locate characters of strings among the characters of the variable Alpha, with condition.
            If InStr(Str1, Char1) = 0 Then
                IsPanagram = False
                Exit For
            End If
        Next
       
    'output suitable prompts
    If IsPanagram Then
            Console.Write("all alphabets are present in the string")
        Else Console.Write("all alpahabets are not present in the string")
        End If









    End Sub




End Module
