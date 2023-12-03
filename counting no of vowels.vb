Imports System

Module Program
    Sub Main()
        'declaration of variables
        Dim Str1 As String
        Dim Ch As Char
        Dim CountA, CountE, CountI, CountO, CountU, i As Integer

        'initialzation
        Str1 = ""
        CountA = 0
        CountE = 0
        CountI = 0
        CountO = 0
        CountU = 0
        i = 0

        'input of string
        Console.Write("enter string: ")
        Str1 = UCase(Console.ReadLine())

        'loops starts to observe each character and count all vowels seperately
        For i = 1 To Len(Str1)
            Ch = Mid(Str1, i, 1)
            If Ch = "A" Then
                CountA = CountA + 1
            ElseIf Ch = "E" Then
                CountE = CountE + 1
            ElseIf Ch = "I" Then
                CountI = CountI + 1
            ElseIf Ch = "O" Then
                CountO = CountO + 1
            ElseIf Ch = "U" Then
                CountU = CountU + 1

            End If
        Next

        'output all the counts
        Console.WriteLine("no of A's are: " & CountA)
        Console.WriteLine("no of E's are: " & CountE)
        Console.WriteLine("no of I's are: " & CountI)
        Console.WriteLine("no of O's are: " & CountO)
        Console.WriteLine("no of U's are: " & CountU)
        Console.ReadLine()

















    End Sub
End Module
