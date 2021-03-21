using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App2.Models;

namespace App2.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        public List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                //Пресс
                new Item { Id = Guid.NewGuid().ToString(), Text = "Скручивания", Description="Это стандартное упражнение на пресс. Именно во время выполнения скручиваний включаются в работу прямая мышца брюшного пресса (она отвечает за кубики на животе), большая грудная мышца, наружные и внутренние косые, а также поперечные мышцы брюшного пресса.", Photo="skruchivaniya_na_press.jpg", Timer="30", Type="Пресс"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Планка", Description="Статическое упражнение на полу с упором на руки или предплечья. Это упражнение считается одним из самых эффективных способов убрать живот и подтянуть тело. Всё, что нужно для его выполнения, – собственный вес и ровная поверхность.", Photo="planka_2.jpg", Timer="60", Type="Пресс"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ножницы", Description="Велосипед — это простое упражнение на прокачку пресса и сгибателей бедра. Оно не требует оборудования и хорошей физической подготовки, может выполняться отдельно или в составе тренировки, по подходам и повторениям или по времени.", Photo="krasivyy_press_6.jpg", Timer="30", Type="Пресс"},
                //Плечи
                new Item { Id = Guid.NewGuid().ToString(), Text = "Подтягивание", Description="Базовое физическое упражнение, развивающее группы мышц верхней части тела: широчайшие, бицепсы, брахиалис, грудные, верхняя часть спины, мышцы брюшной стенки, предплечья.", Photo="scale_1201.jpg", Timer="30", Type="Плечи" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Отжимание в стойке на руках", Description="Эффектное, но довольно сложное упражнение. При хорошей физической форме в стойке на руках можно даже отжиматься. Для этого понадобиться хорошая физическая форма и желание учиться.", Photo="otzhimaniya_v_stojke_na_rukah.jpg", Timer="30", Type="Плечи" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Разводка гантелей в стороны", Description="Базовое упражнение для тренировки мышц плеча, в работу также включаются трапеции и надостная мышца.", Photo="podyemy_ganteley_v_storony.jpg", Timer="30", Type="Плечи" },
                //Грудь
                new Item { Id = Guid.NewGuid().ToString(), Text = "Отжимание", Description="Базовое физическое упражнение, выполняемое в планке и представляющее собой опускание-поднятие тела с помощью рук от пола (предпочтительно), скамьи, стула, стола, стены и т. д.", Photo="scale_1200.jpg", Timer="60", Type="Грудь" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Отжимания на брусьях", Description="Это непревзойденное упражнение для проработки трицепсов и грудных мышц, а также для укрепления плечевого пояса. Наряду с турником, брусья являются одним из самых доступных тренажеров.", Photo="otzhimaniya_na_brusyah_zhim.jpg", Timer="40", Type="Грудь" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Жим штанги лежа", Description="Это одно из пяти базовых упражнений, то есть силовых упражнений, наиболее эффективных для комплексного развития всей мускулатуры тела.", Photo="zhim_shtangi_lezha_1.jpg", Timer="60", Type="Грудь" },
                //Ягодицы
                new Item { Id = Guid.NewGuid().ToString(), Text = "Приседания", Description="Одно из базовых силовых упражнений (в том числе в пауэрлифтинге и культуризме); выполняющий упражнение приседает и затем встаёт, возвращаясь в положение стоя.", Photo="vozdushnye_prisedaniya_uprazhnenie.jpg", Timer="60", Type="Ягодицы"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Мах ногой вверх", Description="При помощи махов вы можете эффективно проработать заднюю, переднюю, внешнюю и внутреннюю поверхность бедра, а также большие и средние ягодичные мышцы.", Photo="ed7ca656e5545543ea7f148a90a3736c.png", Timer="60", Type="Ягодицы"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Запрыгивание на тумбу", Description="лучшее упражнение для развития взрывной силы и выносливости. Оно задействует почти все ягодичные мышци и отлично подходит как для мужчин, так и для женщин.", Photo="pryzhki_na_tumbu.jpg", Timer="60", Type="Ягодицы"},
                //Спина
                new Item { Id = Guid.NewGuid().ToString(), Text = "Становая тяга с гантелями", Description="Базовое (многосуставное) упражнение, выполняемое обычно со штангой, а также с гантелью или гирей, удерживаемыми обеими руками и поднимаемая на уровень опущенных вытянутых рук.", Photo="stanovaya_tyaga_s_gantelyami_s_pryamoj_spinoj.jpg", Timer="40", Type="Спина"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Румынская тяга", Description="одно из лучших базовых и наиболее функциональных упражнений для тренировки бицепса бедер. Румынская тяга также задействует большое количество дополнительных мышц.", Photo="rumynskay.jpg", Timer="30", Type="Спина"},
                //Ноги
                new Item { Id = Guid.NewGuid().ToString(), Text = "Выпады", Description="Упражнение с весом, которое используется для укрепления мышц ног. Длинный выпад в большей степени нагружает ягодицы, тогда как короткий выпад переносит основную нагрузку на квадрицепсы.", Photo="acb87050573c361e31615c536dd3b0ce.jpg", Timer="60", Type="Ноги"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Жим ногами", Description="Второе по популярности базовое упражнение для ног после приседаний. При его выполнении спортсмен выжимает вес в специальном станке силой нижних конечностей.", Photo="Uprazhneni.jpg", Timer="45", Type="Ноги"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Разгибания ног", Description="это изолирующее упражнение на квадрицепс, которое способствует прорисовке рельефа и улучшению формы данной мышцы.", Photo="unnamed.jpg", Timer="45", Type="Ноги"},
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}