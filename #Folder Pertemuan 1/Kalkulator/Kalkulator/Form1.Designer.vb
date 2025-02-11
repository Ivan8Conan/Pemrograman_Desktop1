<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        CmdFactorial = New Button()
        CmdDecimal = New Button()
        CmdAddition = New Button()
        CmdPowerOf = New Button()
        CmdEqual = New Button()
        CmdSign = New Button()
        CmdInverse = New Button()
        CmdSubtract = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd0 = New Button()
        Cmd1 = New Button()
        CmdSqrt = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        Cmd7 = New Button()
        CmdDivision = New Button()
        CmdMultiply = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        cmdBackspace = New Button()
        CmdCbrt = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(32, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 79)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 18F)
        txtInput.Location = New Point(19, 17)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(291, 47)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CmdCbrt)
        Panel2.Controls.Add(CmdFactorial)
        Panel2.Controls.Add(CmdDecimal)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd7)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(32, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 350)
        Panel2.TabIndex = 1
        ' 
        ' CmdFactorial
        ' 
        CmdFactorial.Location = New Point(129, 13)
        CmdFactorial.Name = "CmdFactorial"
        CmdFactorial.Size = New Size(49, 48)
        CmdFactorial.TabIndex = 44
        CmdFactorial.Text = "n!"
        CmdFactorial.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(129, 229)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(49, 48)
        CmdDecimal.TabIndex = 43
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(206, 229)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(49, 48)
        CmdAddition.TabIndex = 42
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(261, 67)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(49, 48)
        CmdPowerOf.TabIndex = 32
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(206, 283)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(104, 48)
        CmdEqual.TabIndex = 41
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(74, 229)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(49, 48)
        CmdSign.TabIndex = 40
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(261, 175)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(49, 48)
        CmdInverse.TabIndex = 39
        CmdInverse.Text = "1/x"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(206, 175)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(49, 48)
        CmdSubtract.TabIndex = 38
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(129, 175)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(49, 48)
        Cmd3.TabIndex = 37
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(74, 175)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(49, 48)
        Cmd2.TabIndex = 36
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(19, 229)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(49, 48)
        Cmd0.TabIndex = 35
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(19, 175)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(49, 48)
        Cmd1.TabIndex = 34
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(261, 121)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(65, 48)
        CmdSqrt.TabIndex = 33
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(129, 121)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(49, 48)
        Cmd6.TabIndex = 31
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(74, 121)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(49, 48)
        Cmd5.TabIndex = 30
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(19, 121)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(49, 48)
        Cmd4.TabIndex = 29
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(129, 67)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(49, 48)
        Cmd9.TabIndex = 28
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(74, 67)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(49, 48)
        Cmd8.TabIndex = 27
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(19, 67)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(49, 48)
        Cmd7.TabIndex = 25
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(206, 67)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(49, 48)
        CmdDivision.TabIndex = 24
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(206, 121)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(49, 48)
        CmdMultiply.TabIndex = 23
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(261, 13)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(49, 48)
        cmdC.TabIndex = 3
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(203, 13)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(52, 48)
        cmdCE.TabIndex = 2
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(19, 13)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(110, 48)
        cmdBackspace.TabIndex = 1
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' CmdCbrt
        ' 
        CmdCbrt.Font = New Font("Segoe UI", 10F)
        CmdCbrt.Location = New Point(261, 229)
        CmdCbrt.Name = "CmdCbrt"
        CmdCbrt.Size = New Size(49, 48)
        CmdCbrt.TabIndex = 45
        CmdCbrt.Text = "∛x"
        CmdCbrt.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 459)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents CmdFactorial As Button
    Friend WithEvents CmdCbrt As Button

End Class
