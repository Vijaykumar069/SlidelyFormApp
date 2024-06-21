<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.DarkTurquoise
        btnCreateSubmission.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCreateSubmission.Location = New Point(326, 452)
        btnCreateSubmission.Margin = New Padding(4, 5, 4, 5)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(534, 128)
        btnCreateSubmission.TabIndex = 0
        btnCreateSubmission.Text = "Create New Submission (Ctrl + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Gold
        btnViewSubmissions.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(326, 200)
        btnViewSubmissions.Margin = New Padding(4, 5, 4, 5)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(534, 152)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "View Submissions (Ctrl + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(313, 38)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(621, 33)
        Label6.TabIndex = 13
        Label6.Text = "Vijay Kumar,s Slidely Task 2 - Slidely Form App"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(Label6)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        KeyPreview = True
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainForm"
        Text = "Vijay Kumar,s Slidely Task 2 - Slidely Form App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents Label6 As Label

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function
End Class
