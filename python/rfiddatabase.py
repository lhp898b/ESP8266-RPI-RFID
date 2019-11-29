#!/usr/bin/python
# coding:utf-8
import serial
import time
import MySQLdb
# 配置数据库实例
dbConn = MySQLdb.connect('xxx', 'xxx', '123456', 'rfidesp', 3306, charset='utf8',  autocommit = True)
device = """/dev/ttyUSB0"""
while True:
    try:
        print "-------------------------------------------"
        print "连接串口中.....", device
        time.sleep(0.2)
        print "........"
        time.sleep(0.2)
        print "........"
        time.sleep(0.2)
        print "........"
        time.sleep(0.2)
        arduino = serial.Serial(device, 9600)
        print "连接成功！！！"
        print "\n\n\n正在进入系统........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.1)
        print "........"
        time.sleep(0.6)
        print "........", "成功!"
        time.sleep(0.5)
        print "\n\n\n\n"
        print "\n"
        print "---------------------------------------------------"
        print "欢迎使用皇冠集团员工考勤系统"
        print "等待读卡......."
        print "\n\n\n\n\n\n\n\n\n\n"
        break
    except:
        print"连接失败！！！(2s后重试......)", device
        time.sleep(0.5)
        print "........"
        time.sleep(1)
        print "........"
        time.sleep(1)
        continue
while True:
    try:
        data = arduino.readline()  # 从串口读取数据
        if data !="":
            flag=0
        print data
        pieces = data.split(": ")  # 分割符划分数据段'''
        piecesint = int(pieces[1])  # 卡号
        print"读取卡片信息........."
        time.sleep(0.2)
        print"......."
        time.sleep(0.2)
        print"......."
        time.sleep(0.2)
        print"......."
        time.sleep(0.2)
        print"......."
        cursor = dbConn.cursor()
        cursor.execute("""SELECT WORKERNAME,WORKERID,SEX,FLAG  FROM rfesp WHERE RFIDNUM=%s""", [piecesint])
        time.sleep(0.5)
        print "--------------------"
        print "读取成功"
        results = cursor.fetchall()
        for row in results:
            name = row[0]
            workid = row[1]
            SEX = row[2]
            FLAG = row[3]
        if FLAG == 1:
            FLAG = "缺勤"
        elif FLAG == 2:
            FLAG = "在岗"
        elif FLAG == 3:
            FLAG = "下班"
        elif FLAG == 4:
            FLAG = "请假"
        elif FLAG == 5:
            FLAG = "外勤"
        display = data.split("    ")  # 分割符划分数据段
        print "--------------------"
        print "信息如下：\n"
        print "工  号:", workid, "\n姓  名:", name, "\n性  别:", SEX, "\n状  态:", FLAG, "\n"
        print "--------------------\n"
        try:
            #print "卡ID：", piecesint
            if FLAG == "缺勤":
                print"数据库写入中......"
                cursor.execute("""UPDATE rfesp SET FLAG=2,QD=now() WHERE RFIDNUM = %s """, [piecesint])
                time.sleep(0.1)
                dbConn.commit()  # 执行语句
                cursor.close()
                print "上班打卡成功，状态已更新！！！\n当前状态：在岗"
            elif FLAG == "在岗":
                print"数据库写入中......"
                cursor.execute("""UPDATE rfesp SET FLAG=3,QT=now() WHERE RFIDNUM = %s """, [piecesint])
                time.sleep(0.1)
                dbConn.commit()  # 执行语句
                cursor.close()
                print "下班打卡成功，状态已更新！！！\n当前状态：下班"
            elif FLAG == "下班":
                time.sleep(0.1)
                print "已经下班打卡成功，请勿重复打卡！！！\n"
            else:
                print "状  态:{}".format(FLAG)
        except MYSQLdb.IntegrityError:
            cursor.close()
            print"数据库信息写入失败！！！"
        finally:
            cursor.close()  # 关闭数据库实例
            print""

    except:
        print"等待串口连接......."
