
'김범진
'->  네트워크 인터페이스 목록 얻기
'->  네트워크 인터페이스에 대한 자세한 정보 얻기
'->  패킷 분석하기


Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports PcapDotNet.Base
Imports PcapDotNet.Core
Imports PcapDotNet.Packets
Imports PcapDotNet.Packets.Arp
Imports PcapDotNet.Packets.Dns
Imports PcapDotNet.Packets.Ethernet
Imports PcapDotNet.Packets.Gre
Imports PcapDotNet.Packets.Http
Imports PcapDotNet.Packets.Icmp
Imports PcapDotNet.Packets.Igmp
Imports PcapDotNet.Packets.IpV4
Imports PcapDotNet.Packets.IpV6
Imports PcapDotNet.Packets.Transport
Imports System.Threading
Imports System.ComponentModel
'//필요한 라이브러리들 추가

Public Class Form1

    Dim Thread1 As New System.Threading.Thread(AddressOf StartThread)
    '//Thread1이라는 쓰레드 만들기

    Dim count As Integer = 0
    Dim _index As Integer = 0
    Dim selected_list As ListViewItem
    '저장할장소 변수 선언부분 
    Dim folderName As String = ""
    Dim pathString As String = ""

    Dim show_as As Boolean = 0


    '/////////트리뷰에 올릴 것들/////////////////
    Dim list_no As String
    Dim list_len As String
    Dim list_time As String
    Dim list_protocol As String
    Dim list_destination_mac As String
    Dim list_source_mac As String
    Dim packets As String


    '///////////////////////////////////////////


    Sub StartThread()
        Using communicator As PacketCommunicator = select_adapter.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000)

            If communicator.DataLink.Kind <> DataLinkKind.Ethernet Then
                MsgBox("이프로그램은 이더넷네트워크에서만 캡처가 된단다")
                Return
            End If

            communicator.ReceivePackets(0, AddressOf PacketHandler)

        End Using
    End Sub
    '//필요한 변수들도 선언해줍시다


    Private Sub PacketHandler(packet As Packet) '//PacketHandler 라는 함수라고 보시면 됩니다

        Dim ip_4 As IpV4Datagram = packet.Ethernet.IpV4
        '//변수ip선언
        '//라이브러리에 있는 IPV4Datagram이라는 형태
        '//packet.Eternet.IPV4는 ip를 뜻하는거겠져?
        count += 1
        Dim item As New ListViewItem(count)
        Dim item2 As New ListViewItem 'print_packet담을 리스트뷰

        item.SubItems.Add(packet.Timestamp.ToString)
        item.SubItems.Add(ip_4.Source.ToString)
        item.SubItems.Add(ip_4.Destination.ToString)
        item.SubItems.Add(ip_4.Protocol.ToString)
        'item.SubItems.Add(ip_4.Protocol.ToString)
        item.SubItems.Add(packet.Length.ToString)
        'item을 넣을 리스트뷰아이템형 변수를 선언후
        'count, time, 출발지ip, 목적지ip, 프로토콜, 패킷데이터길이, 패킷데이터
        '서브아이템들을 item변수에 넣는다.

        Dim i As Integer = 0
        Dim hex_print_packet As String = ""
        Dim bin_print_packet As String = ""
        Dim save_packet As String = ""

        While i <> packet.Length '패킷데이터 길이가 i와 같아질때까지 loop
            hex_print_packet = hex_print_packet + ((packet(i)).ToString("X2")) '16진수
            bin_print_packet = bin_print_packet + Convert.ToString(packet(i), 2).PadLeft(8, "0"c) '2진수

            save_packet = save_packet + Convert.ToString(packet(i), 2).PadLeft(8, "0"c) '패킷저장용 문자열

            hex_print_packet = hex_print_packet + " " '띄어쓰기 1칸(가독성 좋게)
            bin_print_packet = bin_print_packet + " "

            If (i + 1) Mod 16 = 0 Then
                hex_print_packet = hex_print_packet + vbNewLine  '줄바꿈(가독성 좋게)
                bin_print_packet = bin_print_packet + vbNewLine '줄바꿈
                GoTo newline 'goto를 사용해서 8과16의 나머지가 0 이 될때 이상하게 되는걸 방지
            End If

            If (i + 1) Mod 8 = 0 Then
                hex_print_packet = hex_print_packet + "  " '띄어쓰기 3칸 (16진수 데이터들을 보기좋게 하기위해 8칸으로 나눔)
                bin_print_packet = bin_print_packet + vbNewLine '줄바꿈
            End If
newline:'goto를 써서 newline으로 이동한 부분
            i += 1
        End While

        item2.SubItems.Add(hex_print_packet)
        item2.SubItems.Add(bin_print_packet)
        item2.SubItems.Add(save_packet)
        '패킷들을 서브아이템으로 추가

        CheckForIllegalCrossThreadCalls = False
        '쓰레드 오류를 통제하기 위해서 넣었음. (좋지않은방법)

        ListView1.Items.Add(item) 'item변수를 리스트뷰에 추가
        ListView2.Items.Add(item2)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles capture_start.Click
        If capture_start.Text = "다시캡쳐" Then
            Me.Close()
            InterfaceSelect.Button1.PerformClick()
            Exit Sub
        End If
        Thread1.Start() '쓰레드1 시작
        capture_start.Text = "다시캡쳐"
        capture_start.Enabled = False
        capture_stop.Enabled = True
        Label1.Text = "캡쳐중..."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles capture_stop.Click
        Thread1.Abort() '쓰레드1 중지
        capture_stop.Enabled = False
        capture_start.Enabled = True
        Label1.Text = "캡쳐중지"
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged


        If (ListView1.SelectedItems.Count > 0) Then '선택된 item 카운트가 0보다 크면

            _index = ListView1.SelectedItems(0).SubItems(0).Text - 1

            list_no = ListView1.SelectedItems(0).SubItems(0).Text
            list_len = ListView1.SelectedItems(0).SubItems(5).Text
            list_time = ListView1.SelectedItems(0).SubItems(1).Text
            list_protocol = ListView1.SelectedItems(0).SubItems(4).Text

            packets = ListView2.Items(_index).SubItems(3).Text


            TreeView1.Nodes.Clear()

            '///////////////////프레임구조////////////////////////

            TreeView1.Nodes.Add("Frame " + list_no + ": " + list_len + " bytes captured on " + select_adapter.description)
            TreeView1.Nodes(0).BackColor = Color.LightGray
            TreeView1.Nodes(0).Nodes.Add(New TreeNode("Interface ID: " + select_adapter.name))
            TreeView1.Nodes(0).Nodes.Add(New TreeNode("Time Stamp: " + list_time))
            TreeView1.Nodes(0).Nodes.Add(New TreeNode("Packet Length: " + list_len + " bytes"))
            TreeView1.Nodes(0).Nodes.Add(New TreeNode("Protocol: " + list_protocol))
            '/////////////////////////////////////////////////////
            '
            '
            '
            '//////////////////이더넷 프레임 구조///////////////////////////
            TreeView1.Nodes.Add("Ethernet Src: " + list_no + ": " + list_len + " bytes captured on " + select_adapter.description)
            TreeView1.Nodes(1).BackColor = Color.LightGray
            TreeView1.Nodes(1).Nodes.Add(New TreeNode("Destination: " + Bin2Mac(packets.Substring(0, 48))))
            TreeView1.Nodes(1).Nodes.Add(New TreeNode("Source: " + Bin2Mac(packets.Substring(48, 48))))
            TreeView1.Nodes(1).Nodes.Add(New TreeNode("Type: " + Bin2Hex(packets.Substring(96, 16))))
            '//////////////////////////////////////////////////////////////
            '
            '
            '//만약 이더넷프레임구조에서 96번째로 시작하는 패킷의 위치가 0000100000000110 라면 ARP프로토콜임.
            '//(이더넷프레임구조에서 타입(Type)이 ARP 라면)
            '//////////////////ARP 프레임 구조///////////////////////////
            If packets.Substring(96, 16) = "0000100000000110" Then

                If Bin2Dec(packets.Substring(160, 16)) = "1" Then
                    TreeView1.Nodes.Add("ARP Protocol (request)")
                ElseIf Bin2Dec(packets.Substring(160, 16)) = "2" Then
                    TreeView1.Nodes.Add("ARP Protocol (reply)")
                ElseIf Bin2Dec(packets.Substring(160, 16)) = "3" Then
                    TreeView1.Nodes.Add("ARP Protocol (RARP request)")
                ElseIf Bin2Dec(packets.Substring(160, 16)) = "4" Then
                    TreeView1.Nodes.Add("ARP Protocol (RARP reply)")
                Else
                    TreeView1.Nodes.Add("ARP Protocol")
                    End If
                    TreeView1.Nodes(2).BackColor = Color.LightGray

                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Hardware Type: Ethernet (1)"))
                    If packets.Substring(128, 16) = "0000100000000000" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol Type: IPv4 (" + Bin2Hex(packets.Substring(128, 16)) + ")"))
                    Else
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol Type: " + Bin2Hex(packets.Substring(128, 16))))
                    End If
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Hardware size: " + Bin2Dec(packets.Substring(144, 8))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol size: " + Bin2Hex(packets.Substring(152, 8))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Operation code: " + Bin2Dec(packets.Substring(160, 16))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Sender MAC: " + Bin2Mac(packets.Substring(176, 48))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Sender IP: " + Bin2Net(packets.Substring(224, 32))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Target MAC: " + Bin2Mac(packets.Substring(256, 48))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Target IP: " + Bin2Net(packets.Substring(304, 32))))
                End If
                '
                '//만약 이더넷프레임구조에서 96번째로 시작하는 패킷의 위치가 0000100000000000 라면 IPv4프로토콜임.
                '//(이더넷프레임구조에서 타입(Type)이 IPv4 라면)
                '//////////////////IPv4 프레임 구조///////////////////////////
                '
                If packets.Substring(96, 16) = "0000100000000000" Then

                    TreeView1.Nodes.Add("Internet Protocol Version " + Bin2Dec(packets.Substring(112, 4)) + ", Src:" + Bin2Net(packets.Substring(208, 32)) + ", Dst: " + Bin2Net(packets.Substring(240, 32)))
                    TreeView1.Nodes(2).BackColor = Color.LightGray
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode(packets.Substring(112, 4) + " .... = Version: " + Bin2Dec(packets.Substring(112, 4))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("...." + packets.Substring(116, 4) + " = Header Length:" + (Bin2Dec(packets.Substring(116, 4) * 4)) + " bytes (" + Bin2Dec(packets.Substring(116, 4)) + ")"))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Differentiated Services Field: " + Bin2Hex(packets.Substring(120, 8))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Total Length: " + Bin2Dec(packets.Substring(128, 16))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Identification: " + Bin2Hex(packets.Substring(144, 16)) + " (" + Bin2Dec(packets.Substring(144, 16)) + ")"))
                    If packets.Substring(161, 2) = "00" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Flgs: " + Bin2Hex(packets.Substring(160, 3))))
                    ElseIf packets.Substring(161, 1) = "1" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Flgs: " + Bin2Hex(packets.Substring(160, 3)) + "(Don't Fragment)"))
                    ElseIf packets.Substring(162, 1) = "1" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Flgs: " + Bin2Hex(packets.Substring(160, 3)) + "(More Fragments)"))
                    ElseIf packets.Substring(161, 2) = "11" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Flgs: " + Bin2Hex(packets.Substring(160, 3)) + "(Don't Fragment , More Fragments)"))
                    End If
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Fragment offset: " + Bin2Dec(packets.Substring(163, 13))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Time To Live: " + Bin2Dec(packets.Substring(176, 8))))
                    If Bin2Dec(packets.Substring(184, 8)) = "1" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol: ICMP (" + Bin2Dec(packets.Substring(184, 8)) + ")"))
                    ElseIf Bin2Dec(packets.Substring(184, 8)) = "2" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol: IGMP (" + Bin2Dec(packets.Substring(184, 8)) + ")"))
                    ElseIf Bin2Dec(packets.Substring(184, 8)) = "6" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol: TCP (" + Bin2Dec(packets.Substring(184, 8)) + ")"))
                    ElseIf Bin2Dec(packets.Substring(184, 8)) = "17" Then
                        TreeView1.Nodes(2).Nodes.Add(New TreeNode("Protocol: UDP (" + Bin2Dec(packets.Substring(184, 8)) + ")"))
                    End If
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Header Checksum: " + Bin2Hex(packets.Substring(192, 16))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Source: " + Bin2Net(packets.Substring(208, 32))))
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Destination: " + Bin2Net(packets.Substring(240, 32))))
                End If
            '
            '//만약 이더넷프레임구조에서 96번째로 시작하는 패킷의 위치가 1000011011011101 라면 IPv6프로토콜임.
            '//(이더넷프레임구조에서 타입(Type)이 IPv6 라면)
            '//////////////////IPv6 프레임 구조///////////////////////////
            '
            If packets.Substring(96, 16) = "1000011011011101" Then

                TreeView1.Nodes.Add("Internet Protocol Version " + Bin2Dec(packets.Substring(112, 4)) + ", Src:" + Bin2Net6(packets.Substring(176, 128)) + ", Dst: " + Bin2Net6(packets.Substring(304, 128)))
                TreeView1.Nodes(2).BackColor = Color.LightGray
                TreeView1.Nodes(2).Nodes.Add(New TreeNode(packets.Substring(112, 4) + " .... = Version: " + Bin2Dec(packets.Substring(112, 4))))
                TreeView1.Nodes(2).Nodes.Add(New TreeNode("...." + packets.Substring(116, 8) + " .... .... .... .... .... = Traffic class:" + Bin2Hex(packets.Substring(116, 8))))
                TreeView1.Nodes(2).Nodes.Add(New TreeNode(".... .... .... " + packets.Substring(124, 40) + " = Flowlabel: " + Bin2Hex(packets.Substring(124, 40))))
                TreeView1.Nodes(2).Nodes.Add(New TreeNode("Payload length: " + Bin2Dec(packets.Substring(144, 16))))
                If Bin2Dec(packets.Substring(160, 8)) = "1" Then
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Next Header: ICMP" + Bin2Dec(packets.Substring(160, 8)) + " (" + Bin2Dec(packets.Substring(160, 8)) + ")"))
                ElseIf Bin2Dec(packets.Substring(160, 8)) = "6" Then
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Next Header: TCP" + Bin2Dec(packets.Substring(160, 8)) + " (" + Bin2Dec(packets.Substring(160, 8)) + ")"))
                ElseIf Bin2Dec(packets.Substring(160, 8)) = "17" Then
                    TreeView1.Nodes(2).Nodes.Add(New TreeNode("Next Header: UDP" + Bin2Dec(packets.Substring(160, 8)) + " (" + Bin2Dec(packets.Substring(160, 8)) + ")"))
                End If

                TreeView1.Nodes(2).Nodes.Add(New TreeNode("Hop limit: " + Bin2Dec(packets.Substring(168, 8))))
                TreeView1.Nodes(2).Nodes.Add(New TreeNode("Source: " + Bin2Net6(packets.Substring(176, 128))))
                TreeView1.Nodes(2).Nodes.Add(New TreeNode("Destination: " + Bin2Net6(packets.Substring(304, 128))))
            End If



            If show_as = 0 Then
                _index = ListView1.SelectedItems(0).SubItems(0).Text - 1
                TextBox1.Text = ListView2.Items(_index).SubItems(1).Text
            Else
                _index = ListView1.SelectedItems(0).SubItems(0).Text - 1
                TextBox1.Text = ListView2.Items(_index).SubItems(2).Text

            End If
            End If

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Thread1.Abort() '폼을 닫으면 쓰레드종료
        InterfaceSelect.Show()
    End Sub

    Private Sub file_open_Click(sender As Object, e As EventArgs) Handles file_open.Click
        MsgBox("기능구현중")
    End Sub

    Private Sub file_save_Click(sender As Object, e As EventArgs) Handles file_save.Click
        MsgBox("기능구현중")
    End Sub

    Private Sub file_save_as_Click(sender As Object, e As EventArgs) Handles file_save_as.Click

        MsgBox("기능구현중")
    End Sub

    Private Sub ShowAsHexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAsHexToolStripMenuItem.Click
        show_as = 0
        _index = ListView1.SelectedItems(0).SubItems(0).Text - 1
        TextBox1.Text = ListView2.Items(_index).SubItems(1).Text
    End Sub

    Private Sub ShowAsBinaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAsBinaryToolStripMenuItem.Click
        show_as = 1
        _index = ListView1.SelectedItems(0).SubItems(0).Text - 1
        TextBox1.Text = ListView2.Items(_index).SubItems(2).Text
    End Sub


End Class
