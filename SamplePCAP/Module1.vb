Module Module1
    Public select_adapter   '//안뇽? 나는 전역변수인 select_adapter라고 해!! 반가워 ^^

    Public Function Bin2Net(strBin As String) As String
        Dim a1 As String = strBin.Substring(0, 8)
        Dim a2 As String = strBin.Substring(8, 8)
        Dim a3 As String = strBin.Substring(16, 8)
        Dim a4 As String = strBin.Substring(24, 8)

        Dim a1Val As Long
        Dim a2Val As Long
        Dim a3Val As Long
        Dim a4Val As Long

        Dim lastVal As String = ""

        Dim i As Integer
        a1 = Trim(a1)
        For i = 1 To Len(a1)
            a1Val = a1Val + (Val(Mid(a1, Len(a1) - i + 1, 1)) * 2 ^ (i - 1))
        Next i

        For i = 1 To Len(a2)
            a2Val = a2Val + (Val(Mid(a2, Len(a2) - i + 1, 1)) * 2 ^ (i - 1))
        Next i

        For i = 1 To Len(a3)
            a3Val = a3Val + (Val(Mid(a3, Len(a3) - i + 1, 1)) * 2 ^ (i - 1))
        Next i

        For i = 1 To Len(a4)
            a4Val = a4Val + (Val(Mid(a4, Len(a4) - i + 1, 1)) * 2 ^ (i - 1))
        Next i

        lastVal = Trim(CStr(a1Val)) + "." + Trim(CStr(a2Val)) + "." + Trim(CStr(a3Val)) + "." + Trim(CStr(a4Val))

        Bin2Net = lastVal
    End Function
    Public Function Bin2Mac(strBin As String) As String
        Dim a1 As String = strBin.Substring(0, 8)
        Dim a2 As String = strBin.Substring(8, 8)
        Dim a3 As String = strBin.Substring(16, 8)
        Dim a4 As String = strBin.Substring(24, 8)
        Dim a5 As String = strBin.Substring(32, 8)
        Dim a6 As String = strBin.Substring(40, 8)

        Dim a1Val As String = ""
        Dim a2Val As String = ""
        Dim a3Val As String = ""
        Dim a4Val As String = ""
        Dim a5Val As String = ""
        Dim a6Val As String = ""

        Dim lenBin As Integer

        Dim lastVal As String = ""

        lenBin = Len(a1)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a1 = "0" & a1
                Next
            End If
            lenBin = Len(a1)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a1, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a1Val = a1Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a2)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a2 = "0" & a2
                Next
            End If
            lenBin = Len(a2)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a2, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a2Val = a2Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a3)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a3 = "0" & a3
                Next
            End If
            lenBin = Len(a3)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a3, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a3Val = a3Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a4)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a4 = "0" & a4
                Next
            End If
            lenBin = Len(a4)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a4, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a4Val = a4Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a5)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a5 = "0" & a5
                Next
            End If
            lenBin = Len(a5)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a5, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a5Val = a5Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a6)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a6 = "0" & a6
                Next
            End If
            lenBin = Len(a6)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a6, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a6Val = a6Val & Hex(iBin)
            Next
        End If
        lastVal = a1Val + ":" + a2Val + ":" + a3Val + ":" + a4Val + ":" + a5Val + ":" + a6Val

        Bin2Mac = lastVal
    End Function


    Public Function Bin2Dec(strBin As String) As String
        Dim i As Integer
        Dim lVal As Long
        strBin = Trim(strBin)
        For i = 1 To Len(strBin)
            lVal = lVal + (Val(Mid(strBin, Len(strBin) - i + 1, 1)) * 2 ^ (i - 1))
        Next i
        Bin2Dec = Trim(CStr(lVal))
    End Function

    Public Function Bin2Hex(sBin As String)
        Dim sHex As String
        Dim lenBin As Integer

        sHex = "0x"
        lenBin = Len(sBin)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    sBin = "0" & sBin
                Next
            End If
            lenBin = Len(sBin)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(sBin, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                sHex = sHex & Hex(iBin)
            Next
        End If

        Bin2Hex = sHex
    End Function

    Public Function Bin2Net6(strBin As String) As String
        Dim a1 As String = strBin.Substring(0, 16)
        Dim a2 As String = strBin.Substring(16, 32)
        Dim a3 As String = strBin.Substring(32, 48)
        Dim a4 As String = strBin.Substring(48, 64)
        Dim a5 As String = strBin.Substring(64, 80)
        Dim a6 As String = strBin.Substring(80, 96)
        Dim a7 As String = strBin.Substring(96, 112)
        Dim a8 As String = strBin.Substring(112, 128)

        Dim a1Val As String = ""
        Dim a2Val As String = ""
        Dim a3Val As String = ""
        Dim a4Val As String = ""
        Dim a5Val As String = ""
        Dim a6Val As String = ""
        Dim a7Val As String = ""
        Dim a8Val As String = ""

        Dim lenBin As Integer

        Dim lastVal As String = ""

        lenBin = Len(a1)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a1 = "0" & a1
                Next
            End If
            lenBin = Len(a1)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a1, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a1Val = a1Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a2)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a2 = "0" & a2
                Next
            End If
            lenBin = Len(a2)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a2, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a2Val = a2Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a3)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a3 = "0" & a3
                Next
            End If
            lenBin = Len(a3)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a3, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a3Val = a3Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a4)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a4 = "0" & a4
                Next
            End If
            lenBin = Len(a4)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a4, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a4Val = a4Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a5)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a5 = "0" & a5
                Next
            End If
            lenBin = Len(a5)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a5, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a5Val = a5Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a6)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a6 = "0" & a6
                Next
            End If
            lenBin = Len(a6)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a6, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a6Val = a6Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a7)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a7 = "0" & a7
                Next
            End If
            lenBin = Len(a7)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a7, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a7Val = a7Val & Hex(iBin)
            Next
        End If

        lenBin = Len(a8)
        If lenBin > 0 Then
            Dim splitLen As Integer
            Dim splitBin As String
            Dim iBin As Integer
            Dim jBin As Integer
            If lenBin Mod 4 <> 0 Then
                For BHi = 1 To 4 - (lenBin Mod 4)
                    a8 = "0" & a8
                Next
            End If
            lenBin = Len(a8)
            splitLen = lenBin / 4
            For BHi = 1 To splitLen
                splitBin = Mid(a8, ((BHi - 1) * 4) + 1, 4)

                jBin = 8
                iBin = 0
                For BHj = 1 To 4
                    If Mid(splitBin, BHj, 1) = "1" Then
                        iBin = iBin + jBin
                    End If
                    jBin = jBin / 2
                Next
                a8Val = a8Val & Hex(iBin)
            Next
        End If
        lastVal = a1Val + ":" + a2Val + ":" + a3Val + ":" + a4Val + ":" + a5Val + ":" + a6Val + ":" + a7Val + ":" + a8Val

        Bin2Net6 = lastVal
    End Function
End Module
