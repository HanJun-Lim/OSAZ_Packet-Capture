<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.capture_start = New System.Windows.Forms.Button()
        Me.capture_stop = New System.Windows.Forms.Button()
        Me.file_save = New System.Windows.Forms.Button()
        Me.file_save_as = New System.Windows.Forms.Button()
        Me.file_open = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowAsHexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAsBinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(-2, -2)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1222, 256)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "No."
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Time"
        Me.ColumnHeader1.Width = 418
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "source"
        Me.ColumnHeader2.Width = 226
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "destination"
        Me.ColumnHeader3.Width = 228
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "protocol"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "length"
        Me.ColumnHeader5.Width = 90
        '
        'capture_start
        '
        Me.capture_start.Location = New System.Drawing.Point(12, 10)
        Me.capture_start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.capture_start.Name = "capture_start"
        Me.capture_start.Size = New System.Drawing.Size(69, 26)
        Me.capture_start.TabIndex = 1
        Me.capture_start.Text = "캡쳐시작"
        Me.capture_start.UseVisualStyleBackColor = True
        '
        'capture_stop
        '
        Me.capture_stop.Enabled = False
        Me.capture_stop.Location = New System.Drawing.Point(87, 10)
        Me.capture_stop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.capture_stop.Name = "capture_stop"
        Me.capture_stop.Size = New System.Drawing.Size(69, 26)
        Me.capture_stop.TabIndex = 1
        Me.capture_stop.Text = "캡쳐중지"
        Me.capture_stop.UseVisualStyleBackColor = True
        '
        'file_save
        '
        Me.file_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_save.Location = New System.Drawing.Point(1040, 10)
        Me.file_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.file_save.Name = "file_save"
        Me.file_save.Size = New System.Drawing.Size(69, 26)
        Me.file_save.TabIndex = 1
        Me.file_save.Text = "저장"
        Me.file_save.UseVisualStyleBackColor = True
        '
        'file_save_as
        '
        Me.file_save_as.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_save_as.Location = New System.Drawing.Point(1114, 10)
        Me.file_save_as.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.file_save_as.Name = "file_save_as"
        Me.file_save_as.Size = New System.Drawing.Size(118, 26)
        Me.file_save_as.TabIndex = 1
        Me.file_save_as.Text = "다른이름으로저장"
        Me.file_save_as.UseVisualStyleBackColor = True
        '
        'file_open
        '
        Me.file_open.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_open.Location = New System.Drawing.Point(966, 10)
        Me.file_open.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.file_open.Name = "file_open"
        Me.file_open.Size = New System.Drawing.Size(69, 26)
        Me.file_open.TabIndex = 1
        Me.file_open.Text = "파일열기"
        Me.file_open.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(3, 2)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowLines = False
        Me.TreeView1.Size = New System.Drawing.Size(1207, 190)
        Me.TreeView1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1212, 124)
        Me.TextBox1.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAsHexToolStripMenuItem, Me.ShowAsBinaryToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 48)
        '
        'ShowAsHexToolStripMenuItem
        '
        Me.ShowAsHexToolStripMenuItem.Name = "ShowAsHexToolStripMenuItem"
        Me.ShowAsHexToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShowAsHexToolStripMenuItem.Text = "Show as Hex"
        '
        'ShowAsBinaryToolStripMenuItem
        '
        Me.ShowAsBinaryToolStripMenuItem.Name = "ShowAsBinaryToolStripMenuItem"
        Me.ShowAsBinaryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShowAsBinaryToolStripMenuItem.Text = "Show as Binary"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(474, 17)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(21, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 48)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1222, 600)
        Me.SplitContainer1.SplitterDistance = 252
        Me.SplitContainer1.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1217, 334)
        Me.SplitContainer2.SplitterDistance = 198
        Me.SplitContainer2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "캡쳐 대기중..."
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader6})
        Me.ListView2.Location = New System.Drawing.Point(511, 2)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(64, 35)
        Me.ListView2.TabIndex = 7
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        Me.ListView2.Visible = False
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 10
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Width = 10
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 660)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.file_save_as)
        Me.Controls.Add(Me.file_open)
        Me.Controls.Add(Me.file_save)
        Me.Controls.Add(Me.capture_stop)
        Me.Controls.Add(Me.capture_start)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI Sample"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents capture_start As Button
    Friend WithEvents capture_stop As Button
    Friend WithEvents file_save As Button
    Friend WithEvents file_save_as As Button
    Friend WithEvents file_open As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowAsHexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAsBinaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
