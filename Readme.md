# Tìm kiếm trong danh sách
- Là chức năng giúp tìm ra một node có giá trị bằng giá trị cần tìm
- Tạo ra 1 node tạm (currentNode), đóng vai trò như một con trỏ duyệt từ đầu đến cuối danh sách
- Nó dừng lại ở node nào thì đọc dữ liệu ở node đó
- Đồng thời, lấy thông tin về node tiếp theo để tiếp tục duyệt tới
- Các thông tin gán cho node tạm sẽ trực tiếp làm việc trên node nó trỏ tới
- Ban đầu cho node tạm trỏ đến header
- Khi next chưa trỏ đến null, dữ liệu không chứa giá trị cần tìm, duyệt node tạm lướt đến cuối danh sách
- Nếu tìm thấy node có giá trị cần tìm thì dừng lại, trả về thông tin của node đó
- Nếu duyệt đến null mà không tìm thấy thì báo trong danh sách không có giá trị cần tìm
# Duyệt danh sách
- Thực hiện một xử lý nào đó trên tất cả các phần tử của danh sách
- Algorithms này tương tự như searching, nhưng điều kiện dừng của quá trình duyệt là duyệt đến cuối danh sách
- Tạo 1 node tạm (currentNode), tạm thời cho Node này reference đến Header
- Duyệt node tạm đến cuối danh sách, khi node chính cần tìm chưa phải là null
- Dừng ở node nào thì thực hiện lệnh theo yêu cầu
- Bản chất, node tạm chỉ là 1 pointer reference đến node đang xem xét, làm việc với node tạm cũng chính là làm việc với node đang được duyệt
# Chèn phần tử vào giữa danh sách
- Chèn node mới sau node chỉ định
- Dùng phương thức Find để duyệt đến node chỉ định
- Tạo node mới từ parameter input
- Next của node mới reference đến node như next của node tạm
- next của node tạm reference đến node mới
# Remove element khỏi linkedlist
- Dùng phương thức FindPrevious để tìm node trước nó
- Tìm được node phù hợp, next của node đang cần xoá reference đến node phía sau node cần xoá
- Node cần xoá không có node nào reference đến nữa, nghĩa là bị loại khỏi linkedlist
