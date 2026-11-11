# tab = [a,b,c,d,e,f,g,h,i,j,k,l,o,p,q,r,s,t,u,v,w,x,y,z]
# slowo = input("dawaj slowo do zaszyfrowania")
# przesuniecie = int(input("o ile przesunac chcesz"))
#
#
# def cezar (slowo, przesuniecie):
#     output = ""
#     foreach letter in slowo:
#         #indeks = index in tab, where tab[i] = letter
#         gowno = indeks + przesuniecie
#         if gowno > tab.count
#             gowno = gowno - tab.count
#         output += tab[gowno]
#     return output

print(cezar(slowo, przesuniecie))

tab = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
       'w', 'x', 'y', 'z']

slowo = input("dawaj slowo do zaszyfrowania: ")
przesuniecie = int(input("o ile przesunac chcesz: "))

def cezar(slowo, przesuniecie):
    output = ""
    for letter in slowo:
        if letter in tab:
            indeks = tab.index(letter)
            gowno = (indeks + przesuniecie) % len(tab)
            output += tab[gowno]
        else:
            output += letter
    return output


print(cezar(slowo, przesuniecie))
