public class CalculatorController : Controller
{
    [HttpPost]
    public ActionResult Calculate(double num1, double num2, string operation)
    {
        double result = 0;
        switch (operation)
        {
        case "add":
            result = num1 + num2;
            break;
        case "subtract":
            result = num1 - num2;
            break;
        case "multiply":
            result = num1 * num2;
            break;
        case "divide":
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                // Handle division by zero error
            }
            break;
        }
        ViewBag.Result = result; // Pass result to the view
        return View("Index"); // Return the view displaying the result
    }
}