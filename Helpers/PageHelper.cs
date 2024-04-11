using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Helpers
{
    public static class PageHelper
    {
        //Phân trang thông minh
        //Ta tạo class static này mục đích là sử dụng chức năng phân trang như 1 chức năng thuộc class này
        //Như vậy mỗi khi cần đến chức năng phân trang, chỉ duy nhất 1 đối tượng được gọi, tiết kiệm đc tài nguyên
        public static IEnumerable<int> PageNumbers(int pageNumber, int pageCount)
        {
            if (pageCount <= 5)
            {
                for (int i = 1; i <= pageCount; i++)
                {
                    yield return i;
                }
            }
            else
            {

                //Range of 5
                //+2 from left borther or -2 from right borther
                //Ý tưởng là: mỗi khi ta xét số trang, ta chỉ hiển thị 2 trang ở bên phải hoặc trái
                //Ta xét 1 midPoint, đầu tiên nếu nó bé hơn 3 tức ta đang ở trang 1 or 2, ta cho midpoint = 3
                //Sử dụng bt luận lý rút gọn if else ở dưới
                int midPoint = pageNumber < 3 ? 3
                    : pageNumber > pageCount - 2 ? pageCount - 2
                    : pageNumber;

                int lowerBound = midPoint - 2;
                int upperBound = midPoint + 2;

                //if (midPoint < 3)
                //{
                //    midPoint = 3;
                //}
                ////Ta đặt lại midpoint khi đã đạt đến các trang cuối, do khi đó ko còn trang để hiển thị
                ////lúc này ta sẽ cho midpoint bằng tổng số trang trừ đi 2 nếu midoint lớn hơn rìa trái(tổng số trang trừ đi 2)
                //else if (midPoint > pageCount - 2)
                //{
                //    midPoint = pageCount - 2;
                //}

                //ta duyệt 1 vòng lặp đi từ trang 1(ở đây ko phải là trang số 1 mà là trang đầu tiên mà
                //ta làm mốc để duyệt midPoint và từ đó ta hiện chỉ 2 trang bên phải và bên trái,
                //midPoint - 2 sẽ = trang 1)

                //Ta đặt dấu 3 chấm vào giữa phần hiển thị trang
                if (lowerBound != 1)
                {
                    yield return 1;
                    if (lowerBound - 1 > 1)
                    {
                        yield return -1;
                    }
                }

                for (int i = midPoint - 2; i <= upperBound; i++)
                {
                    yield return i;
                }

                //code xử lý đặt dấu chấm vào các trang cuối
                if (upperBound != pageCount)
                {
                    if (pageCount - upperBound > 1)
                    {
                        yield return -1;
                    }
                    yield return pageCount;
                }
            }
        }

    }
}
