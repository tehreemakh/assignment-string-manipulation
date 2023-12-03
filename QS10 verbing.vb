Imports System

Module Program
    Sub Main()

        'declare variables
        Dim Str1, Str2, Str3 As String
        'initialize variables
        Str1 = ""
        Str2 = ""
        Str3 = ""

        'input string
        Console.Write("enter string: ")
        Str1 = Console.ReadLine()
        'introduce variables to store the string which is to be added to the entered string
        Str2 = "ing"
        Str3 = "ly"
        'condition, if length is more than or equal to 3 and string does not have "ing" in the end
        If Len(Str1) >= 3 And Right(Str1, 3) <> Str2 Then
            Str1 = Str1 & Str2
            Console.WriteLine("final string is: " & Str1)
            'condition, if length is more than or equal to 3 and string does have "ing" in the end
        ElseIf Len(Str1) >= 3 And Right(Str1, 3) = Str2 Then
            Str1 = Str1 + Str3
            Console.WriteLine("final string is: " & Str1)
            'condition, if length is less than 3.
        ElseIf Len(Str1) < 3 Then
            Console.WriteLine("final string is: " & Str1)

        End If
        Console.ReadLine()







    End Sub
End Module
