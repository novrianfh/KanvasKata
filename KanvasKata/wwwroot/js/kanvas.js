window.kanvasExport = {
    async exportPng(selector, filename) {
        const el = document.querySelector(selector);
        if (!el) return;

        const canvas = await html2canvas(el, {
            useCORS: true,
            allowTaint: true,
            backgroundColor: null,
            scale: 2,
            logging: false,
        });

        const link = document.createElement('a');
        link.download = filename || 'kanvas.png';
        link.href = canvas.toDataURL('image/png');
        link.click();
    }
};
