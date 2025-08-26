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
