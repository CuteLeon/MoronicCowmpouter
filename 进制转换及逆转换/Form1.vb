Public Class ConversionTool
    '进制转换 Conversion(数值_Long,进制_Long)
    Private Function Conversion(ByVal Number As Long, ByVal JinZhi As Long) As String
        If (36 < JinZhi Or JinZhi < 2 Or Number = 0) Then Conversion = "0" : Exit Function
        Dim Remainder, Quotient As Long
        Quotient = Number
        Do Until Quotient = 0
            Remainder = Quotient Mod JinZhi
            Quotient = (Quotient - Remainder) / JinZhi
            Conversion = IIf(Remainder > 9, Chr(Remainder + 55), Remainder) & Conversion
        Loop
    End Function

    '逆转换 UnConversion(数据_String，进制_Long)
    Private Function UnConversion(ByVal NumberCode As String, ByVal JinZhi As Long) As Long
        Dim Index As Integer, EachCode() As String
        ReDim EachCode(Len(NumberCode))
        NumberCode = UCase(NumberCode)
        For Index = LBound(EachCode) To UBound(EachCode) - 1
            EachCode(Index) = Mid(NumberCode, Len(NumberCode) - Index, 1)
            EachCode(Index) = IIf(Asc(EachCode(Index)) >= 65 And Asc(EachCode(Index)) <= 97, Trim(Str(Asc(EachCode(Index)) - 55)), EachCode(Index))
            UnConversion = UnConversion + EachCode(Index) * (JinZhi ^ Index)
        Next
    End Function

    Private Sub BtnConversion_Click(sender As Object, e As EventArgs) Handles BtnConversion.Click
        TxtResult.Text = Conversion(Val(OctValue.Text), NudJinZhiSet.Value)
    End Sub

    Private Sub BtnUnConversion_Click(sender As Object, e As EventArgs) Handles BtnUnConversion.Click
        OctValue.Text = UnConversion(TxtResult.Text, NudJinZhiSet.Value)
    End Sub

    Private Sub NudJinZhiSet_ValueChanged(sender As Object, e As EventArgs) Handles NudJinZhiSet.ValueChanged
        NudJinZhiSet.Value = IIf(NudJinZhiSet.Value < 2, 2, NudJinZhiSet.Value)
        NudJinZhiSet.Value = IIf(NudJinZhiSet.Value > 36, 36, NudJinZhiSet.Value)
    End Sub
End Class