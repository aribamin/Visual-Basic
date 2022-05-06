<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCardGame))
        Me.picYouOne = New System.Windows.Forms.PictureBox()
        Me.picYouTwo = New System.Windows.Forms.PictureBox()
        Me.picYouThree = New System.Windows.Forms.PictureBox()
        Me.picCompThree = New System.Windows.Forms.PictureBox()
        Me.picCompTwo = New System.Windows.Forms.PictureBox()
        Me.picCompOne = New System.Windows.Forms.PictureBox()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.lblYouSum = New System.Windows.Forms.Label()
        Me.lblCompSum = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblYouWin = New System.Windows.Forms.Label()
        Me.lblCompWin = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        CType(Me.picYouOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYouTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYouThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picYouOne
        '
        Me.picYouOne.Image = Global.CardGame.Amin.My.Resources.Resources.Cardback
        Me.picYouOne.Location = New System.Drawing.Point(12, 36)
        Me.picYouOne.Name = "picYouOne"
        Me.picYouOne.Size = New System.Drawing.Size(116, 170)
        Me.picYouOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYouOne.TabIndex = 0
        Me.picYouOne.TabStop = False
        '
        'picYouTwo
        '
        Me.picYouTwo.Image = Global.CardGame.Amin.My.Resources.Resources.Cardback
        Me.picYouTwo.Location = New System.Drawing.Point(134, 36)
        Me.picYouTwo.Name = "picYouTwo"
        Me.picYouTwo.Size = New System.Drawing.Size(116, 170)
        Me.picYouTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYouTwo.TabIndex = 1
        Me.picYouTwo.TabStop = False
        '
        'picYouThree
        '
        Me.picYouThree.Image = CType(resources.GetObject("picYouThree.Image"), System.Drawing.Image)
        Me.picYouThree.Location = New System.Drawing.Point(256, 36)
        Me.picYouThree.Name = "picYouThree"
        Me.picYouThree.Size = New System.Drawing.Size(116, 170)
        Me.picYouThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYouThree.TabIndex = 2
        Me.picYouThree.TabStop = False
        '
        'picCompThree
        '
        Me.picCompThree.Image = CType(resources.GetObject("picCompThree.Image"), System.Drawing.Image)
        Me.picCompThree.Location = New System.Drawing.Point(724, 36)
        Me.picCompThree.Name = "picCompThree"
        Me.picCompThree.Size = New System.Drawing.Size(116, 170)
        Me.picCompThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCompThree.TabIndex = 3
        Me.picCompThree.TabStop = False
        '
        'picCompTwo
        '
        Me.picCompTwo.Image = CType(resources.GetObject("picCompTwo.Image"), System.Drawing.Image)
        Me.picCompTwo.Location = New System.Drawing.Point(602, 36)
        Me.picCompTwo.Name = "picCompTwo"
        Me.picCompTwo.Size = New System.Drawing.Size(116, 170)
        Me.picCompTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCompTwo.TabIndex = 4
        Me.picCompTwo.TabStop = False
        '
        'picCompOne
        '
        Me.picCompOne.Image = CType(resources.GetObject("picCompOne.Image"), System.Drawing.Image)
        Me.picCompOne.Location = New System.Drawing.Point(480, 36)
        Me.picCompOne.Name = "picCompOne"
        Me.picCompOne.Size = New System.Drawing.Size(116, 170)
        Me.picCompOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCompOne.TabIndex = 5
        Me.picCompOne.TabStop = False
        '
        'cmdPlay
        '
        Me.cmdPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(373, 251)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(113, 49)
        Me.cmdPlay.TabIndex = 6
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'lblYouSum
        '
        Me.lblYouSum.AutoSize = True
        Me.lblYouSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouSum.Location = New System.Drawing.Point(181, 251)
        Me.lblYouSum.Name = "lblYouSum"
        Me.lblYouSum.Size = New System.Drawing.Size(0, 20)
        Me.lblYouSum.TabIndex = 7
        '
        'lblCompSum
        '
        Me.lblCompSum.AutoSize = True
        Me.lblCompSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompSum.Location = New System.Drawing.Point(650, 251)
        Me.lblCompSum.Name = "lblCompSum"
        Me.lblCompSum.Size = New System.Drawing.Size(0, 20)
        Me.lblCompSum.TabIndex = 8
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(318, 320)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(227, 55)
        Me.lblWinner.TabIndex = 9
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYouWin
        '
        Me.lblYouWin.AutoSize = True
        Me.lblYouWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouWin.Location = New System.Drawing.Point(720, 302)
        Me.lblYouWin.Name = "lblYouWin"
        Me.lblYouWin.Size = New System.Drawing.Size(55, 20)
        Me.lblYouWin.TabIndex = 10
        Me.lblYouWin.Text = "You: 0"
        '
        'lblCompWin
        '
        Me.lblCompWin.AutoSize = True
        Me.lblCompWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompWin.Location = New System.Drawing.Point(720, 333)
        Me.lblCompWin.Name = "lblCompWin"
        Me.lblCompWin.Size = New System.Drawing.Size(96, 20)
        Me.lblCompWin.TabIndex = 11
        Me.lblCompWin.Text = "Computer: 0"
        '
        'lblDraws
        '
        Me.lblDraws.AutoSize = True
        Me.lblDraws.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraws.Location = New System.Drawing.Point(720, 362)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(71, 20)
        Me.lblDraws.TabIndex = 12
        Me.lblDraws.Text = "Draws: 0"
        '
        'frmCardGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 393)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblCompWin)
        Me.Controls.Add(Me.lblYouWin)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblCompSum)
        Me.Controls.Add(Me.lblYouSum)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.picCompOne)
        Me.Controls.Add(Me.picCompTwo)
        Me.Controls.Add(Me.picCompThree)
        Me.Controls.Add(Me.picYouThree)
        Me.Controls.Add(Me.picYouTwo)
        Me.Controls.Add(Me.picYouOne)
        Me.Name = "frmCardGame"
        Me.Text = "Card Game"
        CType(Me.picYouOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYouTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYouThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picYouOne As System.Windows.Forms.PictureBox
    Friend WithEvents picYouTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picYouThree As System.Windows.Forms.PictureBox
    Friend WithEvents picCompThree As System.Windows.Forms.PictureBox
    Friend WithEvents picCompTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picCompOne As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents lblYouSum As System.Windows.Forms.Label
    Friend WithEvents lblCompSum As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblYouWin As System.Windows.Forms.Label
    Friend WithEvents lblCompWin As System.Windows.Forms.Label
    Friend WithEvents lblDraws As System.Windows.Forms.Label

End Class
