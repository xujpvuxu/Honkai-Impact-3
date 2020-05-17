import re
import requests,time

user=input("UID:")

op=open("share.txt","r")

for i in range(43):

    ur=op.readline()

    url="https://api-sea.mihoyo.com/bh3-event-e20190926statistics/api/receive?_lang=zh-tw&game_biz=bh3_asia&uid=10002444&cipher=MzcwODc4NTg4MiFhc2lhMDE%3D"
    ua=str(ur).split("&")
    regex= re.compile("cip.*")
    cipher=str(regex.findall(ua[0])[0])

    uid="uid="+user
    a=str(url).split("&")
    url=a[0]+"&"+a[1]+"&"+uid+"&"+cipher

    req=requests.get(url)

    print(req.text)
    if(i==42):
        print("完成")
        time.sleep(5)
op.close()


# r=requests.get("https://www.eyny.com/index.php",a)
# browser.get("https://www.eyny.com/index.php",a)


# a.send_keys(url)

# a=browser.find_element_by_class_name("btn-open-gift")
# a.click()

# browser.close()








