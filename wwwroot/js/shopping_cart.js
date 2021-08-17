
Vue.component('cart-rows', {
    props: ['item'],
    computed: {
        subtotal: function() {
            return this.item.product.price * this.item.amount
        }
    },
    methods: {
        async add(id) {
            const postData = { itemId: id, check: "add" };
            await axios.post("/ShoppingCart/ChangeAmount", postData);
            this.item.amount++;
        },
        async reduce(id) {
            const postData = { itemId: id, check: "reduce" };
            await axios.post("/ShoppingCart/ChangeAmount", postData);
            this.item.amount--;
            if (this.item.amount <= 0) {
                this.$destroy();
                this.$el.parentNode.removeChild(this.$el);
            }

        },
        async remove(id) {
            const postData = { itemId: id, check: "remove" };
            await axios.post("/ShoppingCart/ChangeAmount", postData);
            this.item.amount = 0;
            this.$destroy();
            this.$el.parentNode.removeChild(this.$el);


        }

    },
    template: '<tr class="p-2">\
                    <td class="text-left">{{ item.product.title }}</td>\
                    <td class="text-center">\
                    <a class="pointer" v-on:click="reduce(item.product.productId)">-</a> \
                    {{item.amount}} \
                    <a class="pointer" v-on:click="add(item.product.productId)">+</a></td>\
                    <td class="text-right"> {{item.product.price}} kr<br />{{this.subtotal}} kr</td>\
                    <td class="text-left">\
                        <a class="pointer" v-on:click="remove(item.product.productId)"><i class="far fa-trash-alt"></i></a>\
                    </td>\
                  </tr>'
})

new Vue({
    el: '#app',
    data: {
        shoppingCartItems: [],
        shoppingCartTotal: 0
    },
    computed: {
        total() {
            return this.shoppingCartItems.reduce((sum, item) => sum + item.amount * item.product.price, 0)
        }
    },
    created() {
        axios.get("/ShoppingCart/GetVueData")
            .then(res => {
                this.shoppingCartItems = res.data.shoppingCart.shoppingCartItems,
                    this.shoppingCartTotal = res.data.shoppingCartTotal
            })
    }
});