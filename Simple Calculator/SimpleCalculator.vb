Option Explicit On
Option Strict On

Module SimpleCalculator
    'Jacob Horsley
    'Spring 2025
    'RCET 2265
    'Simple Calculator
    'https://github.com/horsjaco117/Simple-Calculator
    Sub Main()

        Dim userInput As String    'Assigning variables
        Dim firstNumber As Integer
        Dim secondNumber As Integer


        Console.WriteLine("Pick thyself a digit") 'user decides #
        userInput = Console.ReadLine()

        firstNumber = CInt(userInput)

        Console.WriteLine("Choose an additional numero") '# 2
        userInput = Console.ReadLine()

        secondNumber = CInt(userInput)

        'menu below with options. _ is utilized

        Console.WriteLine("What willest thou of the numbers..." & vbNewLine & "(pick an option): " & vbNewLine _
                          & "1. Addition Elixir" & vbNewLine _
                          & "2. Subtractium ore" & vbNewLine _
                          & "3. Multiplication for the gnomes" & vbNewLine)

        userInput = Console.ReadLine() ' user decides

        Console.WriteLine($"Thou hast decided well...")

        'Results of userInput

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
