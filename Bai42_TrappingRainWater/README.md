thuat toan 
c1
phân tích bài toán 1 chút thì b thấy cho 1 mảng n số và tìm lượng nước chứa đc vào những chỗ
rỗng trong đó thì để có thể chứa đc nước thì bên trái và phải phải có giá trị >0 để như 1 bức
tường 2been ở giữa ms có thể chứa ddc nước 
ta se xet tu i =1 trc tsao k xet i bang 0 ư vì bằng 0 thì bên trái nó kcoj nên k để đựng đc nên 
ta bỏ qua công thức sẽ là ta sẽ timg min ( max bên trái, max bên phải ) tại sao lại tìm mix vì 
min ms có thể đựng đc nếu như là max thì sẽ k cân cả 2 bên và ta cần tìm giá trị lớn nhất ở 2 bên
rồi min 2 max lúc này ta tìm đc min r nma nó nó k thể là gtri đựng nước đc ta trừ đi thêm 
height[i] thì t se dc so lượng nước đựng đc nếu như == âm thì là k đựng đc vậy ta tạo 1 biến để
lưu giá trị đó ta duyệt từ i=0 đến Length -2 tsao lai tru 2 vi t xét xung quanh của i nên bên 
phải i còn để giá trị right k thì khi i = lenght -1 thì sẽ bị tràn  trong vòng for ta thêm 2 vòng
while để tìm giá trị lớn nhất 2 bên rồi trừ đi cho height[i] 
ct: Min( maxLeft, maxRight ) - heith[i] nếu lớn hơn 0 là t tìm thấy  rồi t cộng vô cho biến lưu
trữ có thể ra âm vì có chỗ k chứa đc nước nên ta sẽ Max với cả 0 nữa để tránh ra âm thì giá
trị biến lữu trữ k thây đổi cuối cùng return về biến ta đã lưu
c2
c1 thì khi trúng những case lớn thì nó lại time limited nên ms sinh ra c2 
để ý thì b sẽ thấy ở c1 cứ mỗi i ta lại phải tính giá trị lớn nhất cạnh nó vậy thì nếu case lớn
thì sẽ rất lâu nên ta sẽ lưu trc các giá trị lớn nhất duyệt từ trái và từ phải sang 
rồi cách tính như c1 

c3
cach nay thi ta se 2 con tro ta se duyet tu trai phai vo giua
ct min( max left , max right) - h[i]
nen nho h[i] la j h[i] do la gia tri ma t DANG XET 
vay ta se xet neu h[right] > h[left] thi ta se xet ben trai left va
neu h[left] lon hon leftmax thi ta cap nhat leftmax vi luc nay t can phai tim leftmax ma'
con neu h[left] <= leftmax tuc la ta da tim dc leftmax r CHU Y nay vi t da xet ban dau
h[left] < h[right] la sao tuc la gtri cua left nho hon gtri cua right con ben right co the co so
lon hon h[right] nhung ma no lon bao nhieu thi k qtrong vi ta can tim la min( 2 max)
ma ta da bt gtri left < gtri right => min (2 max) = h[left] r ma t da dung h[left] de
tinh dc leftmax tsao lai nhu the vi luu y ta da xet h[left] < h[right] co nghia la min se la h[left]
va ben phai se con co tuong >= h[right] nen muc nuoc se phu thuoc vao leftmax
va khi ta tim dc min chinh la leftmax thi tru cho h[i] nhung ma nen nho la h[i] chinh la gtri
ma ta dasng xet ma ta dang xet ben trai tuc la h[left] nen se la tru cho h[left]
tuong tu neu la ben phai right thi la rightmax - h[right]

sau cung tra ve bien luu tru waterTrap
 















