function toggleMenu() {
    if (document.getElementById("menu").style.display != "block") {
        document.getElementById("menu").style.display = "block";
    }

    else {
        document.getElementById("menu").style.display = "none";
    }
}

const checkScreenSize = () => {
    if (window.innerWidth >= 1200) {
        document.getElementById('menu').classList.remove('hide');
        document.getElementById('account-buttons').classList.remove('hide');
    } else {
        if (!document.getElementById('account-buttons').classList.contains('hide')) {
            document.getElementById('account-buttons').classList.add('hide');
        }
    }
};

window.addEventListener('resize', checkScreenSize);
checkScreenSize();