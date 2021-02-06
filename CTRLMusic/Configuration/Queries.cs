
namespace Configuration
{
    public class Queries
    {
        public class Acessories
        {
            public static string Insert
            {
                get
                {
                    return @" INSERT INTO accessory (instrument_type, measures_id, product_id) 
                              VALUES (@instrument_type, @measures_id, @product_id); ";
                }
            }

            public static string Update
            {
                get
                {
                    return @" UPDATE accessory 
                              SET instrument_type = @instrument_type, measures_id = @measures_id
                              WHERE acessory_id = @acessory_id ";
                }
            }

            public static string SelectAll
            {
                get
                {
                    return @" SELECT product.*, measures.*,
                                     accessory.accessory_id, accessory.instrument_type
                              FROM accessory AS accessory
                              INNER JOIN product AS product ON (accessory.product_id = product.product_id)
                              INNER JOIN measures AS measures ON (accessory.measures_id = measures.measures_id)
                              ORDER BY product.name ASC ";
                }
            }

            public static string GetById
            {
                get
                {
                    return @" SELECT acc.id AS accessory_id, acc.instrument_type, pro.*, mea.*
                              FROM accessory AS acc
                              INNER JOIN product AS pro ON (acc.product_id = pro.id)
                              LEFT JOIN measures AS mea ON (acc.measures_id = mea.id)
                              WHERE acc.id = @accessory_id ";
                }
            }

            public static string DeleteOne
            {
                get
                {
                    return @" DELETE FROM accessory 
                              WHERE accessory_id = @accessory_id
                              AND product_id = @product_id ";
                }
            }


        }
    }
}
