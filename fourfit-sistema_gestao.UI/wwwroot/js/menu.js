document.querySelectorAll('.menu-item > a').forEach(item => {
    item.addEventListener('click', event => {
        event.preventDefault();
        const parent = item.parentElement;
        const submenu = parent.querySelector('.submenu');
        if (submenu) {
            if (parent.classList.contains('open')) {
                submenu.style.maxHeight = '0';
            } else {
                submenu.style.maxHeight = submenu.scrollHeight + 'px';
            }
            parent.classList.toggle('open');
        }
    });
});