thuat toan
tao left =0 right = Length -1 
nhu b thay trong de no bat tinh dien tich lon nhat cua muc nuoc tao thanh
trong mang
thi de tinh dien tich: chieu dai * chieu rong
chieu dai: no chinh la khoang cach tu left den right
con chieu rong: la phan di len se la phan giao cua 2 cot
chinh la giao cua left va right thi la min 
thi t se co chieu dai va rong

ta tao bien max =0 luc nay t ch tim thay nen cho =0

while right > left

ta se tinh dien tich cua left va right r so sanh dt vs max
neu max < dt thi ta update max == dt
neu gtri right ma lon hon ben trai thi ta tang trai len left++
con gtri right nho hon left thi ta giam right -- di
muc dich la de duyet toan bo va tinh tat ca ca dt de so sanh vs max
cuoi cung return max vi ta da so sanh het r 
