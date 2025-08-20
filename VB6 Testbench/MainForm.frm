VERSION 5.00
Begin VB.Form MainForm 
   Caption         =   "WPF ComInterop Testbench"
   ClientHeight    =   3135
   ClientLeft      =   60
   ClientTop       =   405
   ClientWidth     =   4425
   LinkTopic       =   "Form1"
   ScaleHeight     =   3135
   ScaleWidth      =   4425
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShowLateBinding 
      Caption         =   "Show Window (Late Binding)"
      Height          =   975
      Left            =   360
      TabIndex        =   1
      Top             =   1440
      Width           =   3735
   End
   Begin VB.CommandButton cmdShowWindowEarlyBinding 
      Caption         =   "Show Window (Early Binding)"
      Height          =   975
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   3735
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdShowWindowEarlyBinding_Click()

    Dim objWpf As New SimpleComInteropClass
    objWpf.ShowWindow

End Sub

Private Sub cmdShowLateBinding_Click()

    Dim objWpf As Object
    Set objWpf = CreateObject("Wpf.ComInterop.SimpleComInteropClass")
    objWpf.ShowWindow

End Sub
