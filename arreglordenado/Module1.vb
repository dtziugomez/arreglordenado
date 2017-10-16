Module Module1

    Sub Main()
        Dim op As Integer
        Dim conta As Integer = -1
        Dim array(2) As Integer  'ARREGLO DE 3 ELEMENTOS  0-2
        Do
            Console.WriteLine("1-Insertar")
            Console.WriteLine("2-eliminar")
            Console.WriteLine("4-buscar")
            Console.WriteLine("5-ver arreglo")
            Console.WriteLine("6-salir")
            Console.Write("elija una opcion :")
            op = Integer.Parse(Console.ReadLine())
            Select Case op
                Case 1  'insertar elemento
                    If conta = 2 Then
                        Console.WriteLine("El arreglo esta lleno")
                    Else
                        Console.Write("Que valor desea insertar:")
                        Dim val As Integer = Integer.Parse(Console.ReadLine())
                        Dim i As Integer = 0
                        If conta = -1 Then
                            conta += 1
                            array(conta) = val
                        Else
                            While i <= conta And array(i) < val
                                i += 1
                            End While
                            If i = 2 Then
                                conta += 1
                                array(conta) = val
                            Else
                                For j As Integer = 2 To i + 1 Step -1
                                    array(j) = array(j - 1)
                                Next
                                array(i) = val
                                conta += 1
                            End If
                        End If
                    End If
                Case 2 'ëliminar
                    If conta = -1 Then
                        Console.WriteLine("El arreglo est vacio")
                    Else
                        Console.Write("que valor desea eliminar:")
                        Dim val As Integer = Integer.Parse(Console.ReadLine())
                        Dim i As Integer = 0
                        While i <= conta AndAlso array(i) <> val
                            i += 1
                        End While
                        If i > conta Then
                            Console.WriteLine("el valor no esta en el arreglo")
                        Else
                            For j As Integer = i To conta - 1
                                array(j) = array(j + 1)
                            Next
                            array(conta) = Nothing
                            conta -= 1
                        End If
                    End If


                Case 4
                    Console.Write("valor:")
                    Dim val As Integer = 0
                    val = Integer.Parse(Console.ReadLine())
                    Dim i As Integer = 0
                    Dim band As Boolean = True
                    While i < 2
                        If array(i) = val Then
                            Console.WriteLine("el valor si existe")
                            i = 2
                            band = False
                        End If
                        i += 1
                    End While
                    If band = True Then
                        Console.WriteLine("***El valor no existe***")
                    End If
                Case 5
                    Dim i As Integer = 0
                    While i <= 2
                        Console.Write(array(i) & " ")
                        i += 1
                    End While
                    Console.WriteLine("")
            End Select
        Loop While op <> 6
        Console.ReadKey()
    End Sub

End Module
