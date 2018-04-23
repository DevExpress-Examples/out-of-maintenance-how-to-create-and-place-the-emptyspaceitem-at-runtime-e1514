Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim lc As New LayoutControl()
			lc.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Controls.Add(lc)

			Dim labelItem1 As LayoutControlItem = lc.Root.AddItem()
			labelItem1.Name = Guid.NewGuid().ToString()
			labelItem1.Control = New LabelControl()
			labelItem1.Control.Size = New Size(100, 100)
			labelItem1.Text = "1"

			Dim emptySpace As New EmptySpaceItem()
			CType(New DevExpress.XtraLayout.Customization.LayoutItemDragController(emptySpace, labelItem1, DevExpress.XtraLayout.Utils.InsertLocation.After, DevExpress.XtraLayout.Utils.LayoutType.Vertical), DevExpress.XtraLayout.Customization.LayoutItemDragController).DragWildItem()

			Dim labelItem2 As LayoutControlItem = lc.Root.AddItem()
			labelItem2.Name = Guid.NewGuid().ToString()
			labelItem2.Control = New LabelControl()
			labelItem2.Control.Size = New Size(100, 100)
			labelItem2.Text = "2"

		End Sub
	End Class
End Namespace