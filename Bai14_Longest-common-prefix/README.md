thuat toan
ý tưởng của bài là toán là dùng hàm có sẵn là hàm substring để cắt chuối con và
hàm Starwith xem 1 chuỗi có bắt đầu từ 1 chuỗi không 
ta sẽ lấy ptu 0 làm chuối để so sánh xem nó có băt đầu của chuỗi khác không nếu không
thì ta sẽ cắt char cuối của ptu0 đó đến khi nào mà cắt hết sạch r mà vẫn k trùng thì ta 
trả về "" luôn vì không trùng mà nên ta k cần so sánh tiếp
ở đây lưu ý nhất đó là khi ta so sánh Starwith thì while chỉ chạy khi dkien true
mà ta đag làm là nếu Starwith false tức làneeusus chuối ta check vs ptu0 k bắt đầu
thì ta ms cắt nên => false ms cắt chuỗi và true thì out so sánh vs ptu tiếp theo 
tóm tắt lại: Starwith => false => cắt chuỗi(muỗn cắt chuỗi => while true) 
=> nên ta cần đảo lại gtri bằng !
