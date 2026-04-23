window.kanvasUtils = {
    getRenderedImageHeight(itemId) {
        const img = document.querySelector(`[data-item-id="${itemId}"] img`);
        return img ? img.getBoundingClientRect().height : 0;
    }
};

window.kanvasSave = {
    downloadJson(content, filename) {
        const blob = new Blob([content], { type: 'application/json' });
        const url = URL.createObjectURL(blob);
        const a = document.createElement('a');
        a.href = url;
        a.download = filename;
        document.body.appendChild(a);
        a.click();
        document.body.removeChild(a);
        URL.revokeObjectURL(url);
    },
    triggerFilePicker(inputId) {
        document.getElementById(inputId)?.click();
    }
};

window.kanvasExport = {
    async exportPng(selector, filename, scale) {
        const el = document.querySelector(selector);
        if (!el) return;

        const canvas = await html2canvas(el, {
            useCORS: true,
            allowTaint: true,
            backgroundColor: null,
            scale: scale || 1,
            logging: false,
        });

        const link = document.createElement('a');
        link.download = filename || 'kanvas.png';
        link.href = canvas.toDataURL('image/png');
        link.click();
    }
};
