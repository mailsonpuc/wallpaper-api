with open("links.txt") as f:
    for n in f.readlines():
        esplit = n.split()
        estring = str(esplit)
        stringReplace = estring.replace('[','(').replace(']',')')
        print(stringReplace + ',')

        


