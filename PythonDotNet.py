##### C#의 네임스페이스에 _ 있으면 파이썬에서 인식 못함. dll파일명에는 있어도 상관없음 ####

#import sys
#sys.path.append(R'D:\WORK\Desktop\PythonDotNet\Test_DLL\Test_DLL\bin\Release')
import clr
clr.AddReference("System.Windows.Forms")
clr.AddReference("example")
clr.AddReference("Test_DLL")

import example as dll
import TestDLL as dll2
from System.Windows.Forms import Form
import System.Windows.Forms as WinForms
from System import *

WinForms.MessageBox.Show("Hello .net")

'''
my = dll.dllTest
#my.fn_Add(int(2),int(3))
dll.Print.Showmsg
dll.sPrint.Showmsg
'''

#my = dll2.dllTest()
print(dll2.dllTest().fn_Add(1,2))
dll2.Print().Showmsg()

