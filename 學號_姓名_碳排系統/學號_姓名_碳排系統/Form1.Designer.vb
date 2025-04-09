<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumDevices = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblCO2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txbHours = New System.Windows.Forms.TextBox()
        Me.txbCO2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalDevice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(325, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "雲科大碳設備計算"
        '
        'lblNumDevices
        '
        Me.lblNumDevices.AutoSize = True
        Me.lblNumDevices.BackColor = System.Drawing.Color.Transparent
        Me.lblNumDevices.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblNumDevices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumDevices.Location = New System.Drawing.Point(104, 456)
        Me.lblNumDevices.Name = "lblNumDevices"
        Me.lblNumDevices.Size = New System.Drawing.Size(145, 40)
        Me.lblNumDevices.TabIndex = 1
        Me.lblNumDevices.Text = "設備數量"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.Color.Transparent
        Me.lblHours.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHours.Location = New System.Drawing.Point(216, 186)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(127, 36)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "使用時間"
        '
        'lblCO2
        '
        Me.lblCO2.AutoSize = True
        Me.lblCO2.BackColor = System.Drawing.Color.Transparent
        Me.lblCO2.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCO2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCO2.Location = New System.Drawing.Point(216, 247)
        Me.lblCO2.Name = "lblCO2"
        Me.lblCO2.Size = New System.Drawing.Size(211, 36)
        Me.lblCO2.TabIndex = 3
        Me.lblCO2.Text = "每小時碳排放量"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(102, 690)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(262, 50)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "分析結果輸出"
        '
        'txbHours
        '
        Me.txbHours.BackColor = System.Drawing.SystemColors.Info
        Me.txbHours.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txbHours.Location = New System.Drawing.Point(482, 186)
        Me.txbHours.Name = "txbHours"
        Me.txbHours.Size = New System.Drawing.Size(348, 46)
        Me.txbHours.TabIndex = 6
        '
        'txbCO2
        '
        Me.txbCO2.BackColor = System.Drawing.SystemColors.Info
        Me.txbCO2.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txbCO2.Location = New System.Drawing.Point(482, 247)
        Me.txbCO2.Name = "txbCO2"
        Me.txbCO2.Size = New System.Drawing.Size(348, 46)
        Me.txbCO2.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(183, 345)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(244, 51)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "設備添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(561, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(244, 51)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "總碳排放量"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalDevice
        '
        Me.lblTotalDevice.AutoSize = True
        Me.lblTotalDevice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalDevice.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalDevice.ForeColor = System.Drawing.Color.Black
        Me.lblTotalDevice.Location = New System.Drawing.Point(104, 512)
        Me.lblTotalDevice.Name = "lblTotalDevice"
        Me.lblTotalDevice.Size = New System.Drawing.Size(127, 36)
        Me.lblTotalDevice.TabIndex = 10
        Me.lblTotalDevice.Text = "設備介紹"
        '
        'CalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 987)
        Me.Controls.Add(Me.lblTotalDevice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txbCO2)
        Me.Controls.Add(Me.txbHours)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCO2)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblNumDevices)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CalForm"
        Me.Text = "設備碳排監控系統"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumDevices As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblCO2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txbHours As TextBox
    Friend WithEvents txbCO2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotalDevice As Label
End Class
