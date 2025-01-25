Option Explicit On
Option Strict On

Module SimpleCalculator
    'Jacob Horsley
    'Spring 2025
    'RCET 2265
    'Simple Calculator
    Sub Main()

        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer


        Console.WriteLine("Pick thyself a digit")
        userInput = Console.ReadLine()

        firstNumber = CInt(userInput)

        Console.WriteLine("Pick an additional numero")
        userInput = Console.ReadLine()

        secondNumber = CInt(userInput)

        Console.WriteLine("What willest thou of the numbers: " & vbNewLine _
                          & "1. Addition Elixir" & vbNewLine _
                          & "2. Subtractium ore" & vbNewLine _
                          & "3. Multiplication for the gnomes" & vbNewLine)

        userInput = Console.ReadLine()

        Console.WriteLine($"Thou hast decidest well...")

        If userInput = "1" Then
            Console.WriteLine("Addicus Numerus!!!")
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        ElseIf userInput = "2" Then
            Console.WriteLine("Digitus Subtractorius!!!")
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        ElseIf userInput = "3" Then
            Console.WriteLine("MULTIPLICASHITUS!!!")
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
        Else
            Console.WriteLine("PSYCH! YOU SHALL NOT PASS!!!")
        End If

    End Sub

End Module
