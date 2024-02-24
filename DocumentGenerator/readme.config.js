// A marked renderer for mermaid diagrams
const renderer = {
    code(code, infostring) {
        if (infostring === 'mermaid') {
            return `<pre class="mermaid">${code}</pre>`
        }
        return false
    },
};

module.exports = {
    marked_extensions: [{ renderer }],
    dest: './Documentation.pdf',
    stylesheet: ['./readme.css'],
    body_class: 'markdown-body',
    basedir: './..',
    pdf_options: {
        format: 'A4',
        margin: {
            top: '30mm',
            right: '20mm',
            bottom: '20mm',
            left: '30mm'
        },
        headerTemplate: `
        <style>
        section {
            width: 100%;
            display: flex;
            justify-content: space-around;
            font-family: system-ui;
            font-size: 11px;
        }
        section div {
            text-align: center;
            flex-grow: 1;
            flex-basis: 0;
        }
        </style>
        <section>
            <div></div>
            <span> A Legbiztonságosabb Közösségi Oldal - IB152l (2023-2) - Kedd 08:00  </span>
            <div></div>
        </section>
        `,
        footerTemplate: `
        <section>
        <div></div>
        <div>
            Page <span class="pageNumber"></span>
            of <span class="totalPages"></span>
        </div>
        <div>
            Készítette: Horváth Gergely Zsolt <br> Stefán Kornél <br> Vass Kinga
        </div>
        </section>
        `
    },
    script: [
        { url: 'https://cdn.jsdelivr.net/npm/mermaid/dist/mermaid.min.js' },
        // Alternative to above: if you have no Internet access, you can also embed a local copy
        // { content: require('fs').readFileSync('./node_modules/mermaid/dist/mermaid.js', 'utf-8') }
        // For some reason, mermaid initialize doesn't render diagrams as it should. It's like it's missing
        // the document.ready callback. Instead we can explicitly render the diagrams
        { content: 'mermaid.initialize({ startOnLoad: false}); (async () => { await mermaid.run(); })();' }
    ]
};