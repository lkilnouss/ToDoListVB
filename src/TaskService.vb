Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel

Public Module TaskService

    Public Enum Commands
        _add = 0
        _list = 1
        _list_open = 2
        _list_done = 3
        _complete_id = 4
        _delete_id = 5
        _help = 6
        _exit = 7
        _invalid = 8
    End Enum

    Public Function ParseCommand(c As String) As Commands
        Select Case c

            Case "add" Or "add "
                Return 0

            Case "list" Or "list "
                Return 1

            Case "list open" Or "list open "
                Return 2

            Case "list done" Or "list done "
                Return 3

            Case "complete <id>"  'TODOOOOO
                Return 4

            Case "delete <id>"
                Return 5

            Case "help" Or "help "
                Return 6

            Case "exit" Or "exit "
                Return 7

            Case Else
                Return 8

        End Select
    End Function

End Module
