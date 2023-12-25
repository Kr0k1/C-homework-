using Microsoft.AspNetCore.Mvc;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int[] option)
        {
            int result = 0;
            int sum = 0;
            foreach (var numbers in option)
            {
                result += numbers;
                //result = $"{result}{numbers}; ";
            }
            for (int i = 0; i < option.Length; i++)
            {
                sum += 1;
            }

            return $"Кількість параметрів: {sum}; Сумма всіх параметрів: {result}";



        }
    }
}
