'김범진
'->  네트워크 인터페이스 목록 얻기
'->  네트워크 인터페이스에 대한 자세한 정보 얻기
'->  패킷 분석하기
Imports System
Imports System.Collections.Generic
Imports PcapDotNet.Core

Public Class InterfaceSelect
    Dim selectedAdapter As PacketDevice '//PcapDotNet.Core에 포함되어있는 PacketDevice 형식의 selectAdapter 변수 선언
    Dim AdaptersList = LivePacketDevice.AllLocalMachine '//PcapDotNet.Core에 포함되어있는 LivePacketDevice의 랜카드드라이버 리스트 선언

    Private Sub InterfaceSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0    '// 정수형 i를 0으로 변수선언 동시에 0으로 초기화

        While i <> AdaptersList.Count   '//i가 어댑터리스트카운트 숫자 될때까지 loop

            Dim Adapter As LivePacketDevice = AdaptersList(i)   '//어댑터리스트 배열들을 Adapter 변수에 넣어주자

            If Adapter.Description IsNot Nothing Then   '//만약 어댑터의종류가 Nothing이 아니라면

                ComboBox1.Items.Add(Adapter.Description)    '//콤보박스 아이템에 배열[i] 번째 것을 넣어주자
            Else
                ComboBox1.Items.Add("모르는 인터페이스")    '//만약 Nothing 어댑터라면 모르는 인터페이스라고 넣어주자
            End If
            i += 1  '//i는 1씩 증가

        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selectedAdapter = AdaptersList(ComboBox1.SelectedIndex) '//selectedAdapter에 선택된 콤보박스아이템을 넣어주자
        select_adapter = selectedAdapter    '//select_adapter에는 selectAdapter에 담겨져있는것을 넣어주자
        Form1.Show()
        Me.Hide()
        '//form1에 전달하기 위해서 Module1에 select_adapter라는 전역변수를 선언해줬음
    End Sub
End Class