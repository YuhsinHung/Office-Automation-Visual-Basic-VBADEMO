Public Class CalForm

    '宣告變數-和JAVA依樣
    ' 初始化總二氧化碳排放量變數
    Dim totalCO2 As Double = 0.0
    ' 設定設備數量的變數
    Dim numDevices As Integer
    ' 設備使用小時數的陣列
    Dim deviceHours() As Double
    ' 每小時二氧化碳排放量的陣列
    Dim co2PerHour() As Double



    Private Sub CalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 初始化設備使用小時數的陣列,設為0
        ReDim deviceHours(0)
        '初始化每小時二氧化碳排放量的陣列,設為0
        ReDim co2PerHour(0)
        '[學生改]請把雲寶寶改成你名字,並於聯絡方式補上你的EMAIL
        MsgBox("歡迎使用碳排放計算系統！藉由輸入設備數量、使用時間及每小時碳排放量。本系統將提供計算結果以供參考" & vbCrLf & "任何問題請找窗口雲寶寶,聯絡方式", MsgBoxStyle.Information, "初始化")
        '進階語法:未來可以加入vbCrLf來換行,範例MsgBox("這是第一行" & vbCrLf & "這是第二行")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' 增加設備數量,陣列總容量更新
        numDevices += 1
        ' 設備使用時間陣列容量為最新容量
        '[公式] ReDim Preserve 陣列名稱(容量)
        ReDim Preserve deviceHours(numDevices)
        ' 使用小時數陣列增加1為最新容量
        '[公式] ReDim Preserve 陣列名稱(容量)
        ReDim Preserve co2PerHour(numDevices)
        '宣告lastMachineIdx為陣列索引
        Dim lastMachineIdx As Integer
        '最後一個陣列元素索引=最新容量
        lastMachineIdx = numDevices
        '初始化-重新更新設備計算結果
        lblNumDevices.Text = "目前設備共" & numDevices.ToString() & "台"

        ' 輸入框設備使用時間加入陣列
        deviceHours(lastMachineIdx) = CDbl(txbHours.Text)
        '輸入框每小時碳排放量加入陣列
        co2PerHour(lastMachineIdx) = CDbl(txbCO2.Text)

        ' 清空輸入框
        txbHours.Clear()
        txbCO2.Clear()
        Dim deviceNote As String
        deviceNote = "設備" & numDevices.ToString() & ",使用時間" & deviceHours(lastMachineIdx) & "小時;單位碳排量=" & co2PerHour(lastMachineIdx)

        '每台設備,用累加APPEND方式顯示於介面
        lblTotalDevice.Text += vbCrLf & deviceNote

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' 總二氧化碳排放量
        totalCO2 = 0.0
        '宣告設備索引
        Dim mIdx As Integer
        For mIdx = 1 To numDevices
            Dim deviceCO2 As Double

            ' 如果每小時碳排放量超過零，進行計算
            If co2PerHour(mIdx) > 0 Then
                deviceCO2 = deviceHours(mIdx) * co2PerHour(mIdx)
                '否則設為0
            Else
                deviceCO2 = 0
            End If

            totalCO2 += deviceCO2
        Next
        '輸出結果
        lblResult.Text = "總碳排放量（公斤）： " & totalCO2

    End Sub
End Class
