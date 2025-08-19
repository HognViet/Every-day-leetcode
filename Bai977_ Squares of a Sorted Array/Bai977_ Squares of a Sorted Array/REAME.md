thuat toan
c1
 tao bien left = 0 duyet tu trai sang
tao bien right = Length -1 duyet tu phai sang

khi right < left thi cta se dung lai tai vi mang da dc sap xep r

moi lan lap chi can binh phuong nums[left] vs nums[right] la dc
roi sap xep lai la dc Sort
roi return nums
cach nay la cach toi uu cua cach bth thay vi duyen tu dau den cuoi thi ta da rut 
ngan thoi gian duyet di 1 nua

c2
Ta cung tao 2 bien
left =0
right = Length -1
tao them bien pos = Length -1( o day ta se dien ket qua tu cuoi len tuc la lay so lon nhat r dan dan ve sau)
 de luu vi tri ket qua
tao Mang result co kich thuoc = mang nums
thay vi binh phuong nhu c1 thi ta
so sanh gia tri tuyet doi vi co the mang co so am 
so am khi khi gia tri tuyet doi co the lon hon so duong

vi la mang sap xep tang dan
nen khi Abs left < Abs right thi so right binh phuong lon hon left binh phuong 
ta cap nhat result[pos] = rigth bp
pos-- de dien tiep gia tri dang trc
right -- vii right dang duyet tu phai sang

nguoc lai neu Abs left < Abs right thi 
ta cap nhat result[pos] = left bp
pos-- van phai giam de dien gtri dangg trv
left ++ vi left tu trai sang

vong lap dung lai khi right < left
tsao u
vi right va left la index ma di ngc nhau
nen khi right nho hon left tuc la da duuyet xong het r

cuoi cung return result thay vi nums vi ket qua ta luu o result

cach nay se toi uu best run time hon va k can Sort thi ta da thuc hien luon r
