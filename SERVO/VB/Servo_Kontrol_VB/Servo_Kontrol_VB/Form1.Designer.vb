<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnBağlantıKes = New System.Windows.Forms.Button()
        Me.BtnBağlantıAç = New System.Windows.Forms.Button()
        Me.VeriHızı = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComPort = New System.Windows.Forms.ComboBox()
        Me.BtnComPort = New System.Windows.Forms.Button()
        Me.Derece_45 = New System.Windows.Forms.Button()
        Me.Derece_90 = New System.Windows.Forms.Button()
        Me.derece135 = New System.Windows.Forms.Button()
        Me.Derece_180 = New System.Windows.Forms.Button()
        Me.Random = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnDrc0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBağlantıKes
        '
        Me.BtnBağlantıKes.Location = New System.Drawing.Point(220, 12)
        Me.BtnBağlantıKes.Name = "BtnBağlantıKes"
        Me.BtnBağlantıKes.Size = New System.Drawing.Size(66, 58)
        Me.BtnBağlantıKes.TabIndex = 26
        Me.BtnBağlantıKes.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kes"
        Me.BtnBağlantıKes.UseVisualStyleBackColor = True
        '
        'BtnBağlantıAç
        '
        Me.BtnBağlantıAç.Location = New System.Drawing.Point(220, 12)
        Me.BtnBağlantıAç.Name = "BtnBağlantıAç"
        Me.BtnBağlantıAç.Size = New System.Drawing.Size(66, 60)
        Me.BtnBağlantıAç.TabIndex = 25
        Me.BtnBağlantıAç.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aç"
        Me.BtnBağlantıAç.UseVisualStyleBackColor = True
        '
        'VeriHızı
        '
        Me.VeriHızı.FormattingEnabled = True
        Me.VeriHızı.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.VeriHızı.Location = New System.Drawing.Point(93, 51)
        Me.VeriHızı.Name = "VeriHızı"
        Me.VeriHızı.Size = New System.Drawing.Size(121, 21)
        Me.VeriHızı.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Veri Hızı : "
        '
        'ComPort
        '
        Me.ComPort.FormattingEnabled = True
        Me.ComPort.Location = New System.Drawing.Point(93, 14)
        Me.ComPort.Name = "ComPort"
        Me.ComPort.Size = New System.Drawing.Size(121, 21)
        Me.ComPort.TabIndex = 22
        '
        'BtnComPort
        '
        Me.BtnComPort.Location = New System.Drawing.Point(12, 12)
        Me.BtnComPort.Name = "BtnComPort"
        Me.BtnComPort.Size = New System.Drawing.Size(75, 23)
        Me.BtnComPort.TabIndex = 21
        Me.BtnComPort.Text = "Port Ara"
        Me.BtnComPort.UseVisualStyleBackColor = True
        '
        'Derece_45
        '
        Me.Derece_45.Location = New System.Drawing.Point(68, 78)
        Me.Derece_45.Name = "Derece_45"
        Me.Derece_45.Size = New System.Drawing.Size(50, 50)
        Me.Derece_45.TabIndex = 28
        Me.Derece_45.Text = "45"
        Me.Derece_45.UseVisualStyleBackColor = True
        '
        'Derece_90
        '
        Me.Derece_90.Location = New System.Drawing.Point(124, 78)
        Me.Derece_90.Name = "Derece_90"
        Me.Derece_90.Size = New System.Drawing.Size(50, 50)
        Me.Derece_90.TabIndex = 29
        Me.Derece_90.Text = "90"
        Me.Derece_90.UseVisualStyleBackColor = True
        '
        'derece135
        '
        Me.derece135.Location = New System.Drawing.Point(180, 77)
        Me.derece135.Name = "derece135"
        Me.derece135.Size = New System.Drawing.Size(50, 50)
        Me.derece135.TabIndex = 30
        Me.derece135.Text = "135"
        Me.derece135.UseVisualStyleBackColor = True
        '
        'Derece_180
        '
        Me.Derece_180.Location = New System.Drawing.Point(236, 77)
        Me.Derece_180.Name = "Derece_180"
        Me.Derece_180.Size = New System.Drawing.Size(50, 50)
        Me.Derece_180.TabIndex = 31
        Me.Derece_180.Text = "180"
        Me.Derece_180.UseVisualStyleBackColor = True
        '
        'Random
        '
        Me.Random.Location = New System.Drawing.Point(12, 134)
        Me.Random.Name = "Random"
        Me.Random.Size = New System.Drawing.Size(274, 50)
        Me.Random.TabIndex = 32
        Me.Random.Text = "Random"
        Me.Random.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 510
        '
        'BtnDrc0
        '
        Me.BtnDrc0.Location = New System.Drawing.Point(12, 78)
        Me.BtnDrc0.Name = "BtnDrc0"
        Me.BtnDrc0.Size = New System.Drawing.Size(50, 50)
        Me.BtnDrc0.TabIndex = 33
        Me.BtnDrc0.Text = "0"
        Me.BtnDrc0.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 205)
        Me.Controls.Add(Me.BtnDrc0)
        Me.Controls.Add(Me.Random)
        Me.Controls.Add(Me.Derece_180)
        Me.Controls.Add(Me.derece135)
        Me.Controls.Add(Me.Derece_90)
        Me.Controls.Add(Me.Derece_45)
        Me.Controls.Add(Me.BtnBağlantıKes)
        Me.Controls.Add(Me.BtnBağlantıAç)
        Me.Controls.Add(Me.VeriHızı)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComPort)
        Me.Controls.Add(Me.BtnComPort)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBağlantıKes As Button
    Friend WithEvents BtnBağlantıAç As Button
    Friend WithEvents VeriHızı As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComPort As ComboBox
    Friend WithEvents BtnComPort As Button
    Friend WithEvents Derece_45 As Button
    Friend WithEvents Derece_90 As Button
    Friend WithEvents derece135 As Button
    Friend WithEvents Derece_180 As Button
    Friend WithEvents Random As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BtnDrc0 As Button
End Class
