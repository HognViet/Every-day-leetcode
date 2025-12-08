thuat toan
đây là thuật toán cơ bản của bài này khi mà mô tả lại hàm Pow dùng các công
thức toán học để vào vòng for còn bên ngoài là các trường hợp cụ thể của từng cái 
khi tôi chạy đến Case304 trở đi
bài này nó thuộc topics đệ quy và mất 1 khoảng hơi lâu thì tôi ms làm đc mặc dù biết
là dùng đệ quy
nó là hàm mũ (x)^n thì ta có thể biến đổi như sau
    thứ nhất đó là điều kiện dừng khi xây dựng cấu trúc đệ quy thì tôi luôn tìm điều kiện
để dừng
đó là khi n = 0 vd: x ^0 thì với mọi x khi có mũ 0  thì luôn bằng 1 => ta return 1 luôn
và khi x = 1 vd: x ^ 1 thì ms mọi x khi có số mũ 1 thì luôn bằng x => return x
đó là 2 điều kiện base để dừng
ta sẽ chuyển n sang kiểu long vì khi test case có max min của int
ta sẽ sử lý số âm trc khi n < 0 tức là mũ âm đó thì cập nhật x = 1 / x lúc này x tự đã đc đổi
và đương nhiên là cập nhật n thành số dương

Ở c2 ta học (a ^ m) ^n = a ^(n *m) thì dựa vào đó ta đc vd (3)^10 = (3^2)^5 = 9 ^ 5
                                                        => (3*3)^5
để ý 1 chút ae có thể thấy từ (3)^10 = (3*3)^5
vậy nếu x^n = 3^10 từ đó ta đc x^10 = (x*x)^(n /2)
thì đó ta có thể suy ra đc ct vs số mũ n chẵn
Vậy nếu n lẻ thì sao ta có 2^2 = 2* 2
                            2^3 = 2*2*2
                            2^4 = 2*2*2*2
NẾU ta viết 2^3 = 2*2*2 = 2 * (2*2) = 2 * (2^2)
=> 2^3 = 2 *(2^2)
x^n = x * (x^(n-1))
và đó là trường hợp số mũ lẻ
<3
