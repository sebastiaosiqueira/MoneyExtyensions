namespace MoneyExtension;

public static class Money
{
   
        public static int ToCents(this decimal amount){
            if(amount <= 0)
            return 0;

            var valeu = amount.ToString(format:"N2").Replace(oldValue:",", newValue:"").Replace(oldValue:".",newValue:"");
            if(string.IsNullOrEmpty(valeu))
            return 0;

            int.TryParse(valeu, out var result );
            return result;
       
    }

}
