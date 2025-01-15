document.addEventListener("DOMContentLoaded", function () {
    const themeDropdown = document.querySelector('.dropdown[title="Change theme"]');
    if (themeDropdown) {
      themeDropdown.remove();
    }
  });