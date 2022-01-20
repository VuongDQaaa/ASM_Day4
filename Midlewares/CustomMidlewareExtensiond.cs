namespace ASM_Day4.Midlewares
{
    public static class CustomMidlewareExtensiond
    {
        public static IApplicationBuilder UseCustomMidleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoginMidleware>();
        }
    }
}