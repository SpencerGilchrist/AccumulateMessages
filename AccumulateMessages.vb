Module AccumulateMessages

    'Spencer Gilchrsit
    'RCET 0265
    'Message storage
    '2/13/21

    Sub Main()

        Console.WriteLine("Write your message.")
        AccumulateMessages.UserMessages(Console.ReadLine, False)
        AccumulateMessages.UserMessages(Console.ReadLine, False)
        AccumulateMessages.UserMessages(Console.ReadLine, False)
        Console.WriteLine()
        Console.WriteLine(AccumulateMessages.UserMessages("", False))
        Console.Read()

    End Sub

    Function UserMessages(ByVal NewMessage As String, ByVal clear As Boolean) As String

            Static Messages As String

            If clear = False Then

                If NewMessage = "" Then

                Else
                    Messages &= NewMessage & vbNewLine

                End If

            ElseIf clear = True Then
                Messages = ""

            End If


            Return Messages


        End Function

    End Module


